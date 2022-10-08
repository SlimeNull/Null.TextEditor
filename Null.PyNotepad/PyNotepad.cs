using Microsoft.Scripting.Hosting;
using Null.PyNotepad.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable enable
namespace Null.PyNotepad
{
    public partial class PyNotepad : Form
    {
        const string AppName = "PyNotepad";
        const string AppFullName = "Null.PyNotepad";
        bool? appendOrDelete = null;

        string? filepath = null;
        string lastSaved = string.Empty;


        const int lineNumberPaintDelayAfterZoom = 100;

        public RichTextBox TextEditor => textEditor;

        public PyNotepad()
        {
            InitializeComponent();

            findAndReplaceDialog = new FindAndReplaceDialog(this);

            lineNumber.Paint += LineNumber_Paint;
            textEditor.TextChanged += TextEditor_Paint;
            textEditor.VScroll += TextEditor_Paint;
            textEditor.MouseWheel += TextEditor_MouseWheel;

            lineNumber.DataBindings.DefaultDataSourceUpdateMode =
                appStatus.DataBindings.DefaultDataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;

            lineNumber.DataBindings.Add(nameof(Visible), lineNumberToolStripMenuItem, nameof(lineNumberToolStripMenuItem.Checked));
            appStatus.DataBindings.Add(nameof(Visible), statusBarToolStripMenuItem, nameof(statusBarToolStripMenuItem.Checked));
            textEditor.DataBindings.Add(nameof(textEditor.WordWrap), wordWrapToolStripMenuItem, nameof(wordWrapToolStripMenuItem.Checked));

            Text = AppFullName;

            pythonShellDialog = new Lazy<PythonShellDialog>(() =>
            {
                PythonShellDialog _pythonShellDialog = new PythonShellDialog(this);
                _pythonShellDialog.DataBindings.Add(nameof(Visible), pythonWindowToolStripMenuItem, nameof(pythonWindowToolStripMenuItem.Checked));
                return _pythonShellDialog;
            });
        }

        /// <summary>
        /// 统一处理窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PyNotepad_Load(object sender, EventArgs e)
        {
            textEditor.ResetText();
        }

        /// <summary>
        /// 行号显示框重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LineNumber_Paint(object sender, PaintEventArgs e)
        {
            PaintLineNumber();
        }

        /// <summary>
        /// 文本框重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextEditor_Paint(object sender, EventArgs e)
        {
            PaintLineNumber();
        }

        private void TextEditor_MouseWheel(object sender, MouseEventArgs e)
        {
            PaintLineNumberAfter(lineNumberPaintDelayAfterZoom);
            zoomStripStatusLabel.Text = textEditor.ZoomFactor.ToString("P0");
        }

        /// <summary>
        /// 绘制行号主逻辑
        /// </summary>
        private void PaintLineNumber()
        {
            if (!lineNumber.Visible)
            {
                return;
            }

            Point startLocation = new Point(0, 0);
            int startCharIndex = textEditor.GetCharIndexFromPosition(startLocation);
            int startLine = textEditor.GetLineFromCharIndex(startCharIndex);

            using (BufferedGraphics bufferedGraphics =
                BufferedGraphicsManager.Current.Allocate(lineNumber.CreateGraphics(), lineNumber.ClientRectangle))
            {
                Graphics g = bufferedGraphics.Graphics;
                Font font = new Font(Font.FontFamily, textEditor.Font.Size * textEditor.ZoomFactor);

                g.Clear(lineNumber.BackColor);

                int maxWidth = -1;
                Brush brush = Brushes.Black;
                int line = startLine, lastY = -1;
                int curY = curY = textEditor.GetPositionFromCharIndex(textEditor.GetFirstCharIndexFromLine(line)).Y;
                do
                {
                    string textToDraw = (line + 1).ToString();
                    maxWidth = Math.Max(maxWidth, (int)g.MeasureString(textToDraw, font).Width);
                    g.DrawString(textToDraw, font, brush, 3, curY + 1);
                    lastY = curY;

                    line++;
                    curY = textEditor.GetPositionFromCharIndex(textEditor.GetFirstCharIndexFromLine(line)).Y;
                }
                while (curY > lastY);

                lineNumber.Width = maxWidth + 6;

                bufferedGraphics.Render();
            }

        }

        /// <summary>
        /// 在指定时间后绘制行号
        /// </summary>
        /// <param name="milliseconds"></param>
        private async void PaintLineNumberAfter(int milliseconds)
        {
            await Task.Delay(milliseconds).ConfigureAwait(true);
            PaintLineNumber();
        }

        /// <summary>
        /// 带有UI询问的打开文件
        /// </summary>
        private void UiOpenFile()
        {
            if (IsUnsaved())
            {
                DialogResult result = MessageBox.Show(this, "Do you want to save changes?", "Save", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    UiSaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// 带有UI询问的保存文件
        /// </summary>
        private void UiSaveFile()
        {
            if (filepath == null)
            {
                UiSaveAsFile();
            }
            else
            {
                SaveFile(filepath);
            }
        }

        /// <summary>
        /// 带有UI询问的另存为文件
        /// </summary>
        private void UiSaveAsFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog.FileName);
            }
        }

        private void UiPrintFile()
        {

        }

        /// <summary>
        /// 纯保存文件逻辑 (带有报错)
        /// </summary>
        /// <param name="filepath"></param>
        private void OpenFile(string filepath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    this.filepath = filepath;
                    lastSaved = filepath;
                    textEditor.Text = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error, cannot open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 纯保存文件逻辑 (带有报错)
        /// </summary>
        /// <param name="filepath"></param>
        private void SaveFile(string filepath)
        {
            try
            {
                lastSaved = textEditor.Text;
                string ext = Path.GetExtension(filepath);
                if (ext.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    textEditor.SaveFile(filepath, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    textEditor.SaveFile(filepath, RichTextBoxStreamType.RichText);
                }

                UpdateTitlebarText(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error, cannot save file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 是否有未保存的更改
        /// </summary>
        /// <returns></returns>
        private bool IsUnsaved()
        {
            return textEditor.Text != lastSaved;
        }

        /// <summary>
        /// 获取文件显示名
        /// </summary>
        /// <returns></returns>
        private string GetFileDisplayName()
        {
            if (filepath == null)
            {
                return "Untitled.txt";
            }
            else
            {
                return Path.GetFileName(filepath);
            }
        }

        /// <summary>
        /// 统一处理文本更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            UpdateTitlebarText();

            if (appStatus.Visible)
            {
                int selectionStart = textEditor.SelectionStart;
                line.Text = (textEditor.GetLineFromCharIndex(selectionStart) + 1).ToString();
                column.Text = (selectionStart - textEditor.GetFirstCharIndexOfCurrentLine() + 1).ToString();
                charCount.Text = textEditor.Text.Length.ToString();
            }
        }

        private void UpdateTitlebarText(bool saved = false)
        {
            // Title bar
            string filename = GetFileDisplayName();
            if (saved || lastSaved == null || lastSaved != textEditor.Text)
            {
                Text = $"*{filename} - {AppName}";
            }
            else
            {
                Text = $"{filename} - {AppName}";
            }
        }

        /// <summary>
        /// 切换行号显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEditor_DoubleClick(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                lineNumber.Visible ^= true;
            }
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectAll();
        }

        /// <summary>
        /// 窗口关闭
        /// 未保存检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PyNotepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUnsaved())
            {
                DialogResult result = MessageBox.Show(this, "Do you want to save the changes?", "Save", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filepath);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            e.Cancel = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UiOpenFile();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UiOpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UiSaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UiSaveAsFile();
        }

        private void insertDateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectedText = DateTime.Now.ToString("H:m yyyy/M/d");
        }

        private void insertDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectedText = DateTime.Now.ToString("yyyy/M/d");
        }

        private void insertTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectedText = DateTime.Now.ToString("H:m");
        }

        FindAndReplaceDialog findAndReplaceDialog;
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findAndReplaceDialog.SetAppropriatePosition();
            findAndReplaceDialog.ToggleToFind();
            findAndReplaceDialog.Show(this);
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findAndReplaceDialog.SetAppropriatePosition();
            findAndReplaceDialog.ToggleToReplace();
            findAndReplaceDialog.Show(this);
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textEditor.ZoomFactor < 5)
            {
                textEditor.ZoomFactor += 0.1f;
                PaintLineNumberAfter(lineNumberPaintDelayAfterZoom);
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textEditor.ZoomFactor > 0.1f)
            {
                textEditor.ZoomFactor -= 0.1f;
                PaintLineNumberAfter(lineNumberPaintDelayAfterZoom);
            }
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.ZoomFactor = 1;
            PaintLineNumberAfter(lineNumberPaintDelayAfterZoom);
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBarToolStripMenuItem.Checked ^= true;
        }

        /// <summary>
        /// 切换行号显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lineNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordWrapToolStripMenuItem.Checked ^= true;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordWrapToolStripMenuItem.Checked ^= true;
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findAndReplaceDialog.FindNext();
        }

        private void replaceNextStripMenuItem_Click(object sender, EventArgs e)
        {
            findAndReplaceDialog.ReplaceNext();
        }

        Lazy<PythonShellDialog> pythonShellDialog;
        private void pythonWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pythonShellDialog.Value.Visible)
            {
                pythonShellDialog.Value.Hide();
                pythonWindowToolStripMenuItem.Checked = false;
            }
            else
            {
                pythonShellDialog.Value.Show(this);
                pythonWindowToolStripMenuItem.Checked = true;
            }
        }

        private void textEditor_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (Control.ModifierKeys.HasFlag(Keys.Control))
            {
                Process.Start(e.LinkText);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textEditor.Font = fontDialog.Font;
                PaintLineNumberAfter(lineNumberPaintDelayAfterZoom);
            }
        }
    }
}
