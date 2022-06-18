using Null.PyNotepad.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null.PyNotepad.Dialogs
{
    internal partial class FindAndReplaceDialog : Form
    {
        public readonly FindAndReplaceDialogModel ViewModel;
        private readonly PyNotepad rootNotepad;

        public FindAndReplaceDialog(PyNotepad notepad)
        {
            InitializeComponent();
            this.rootNotepad = notepad;

            this.ViewModel = new FindAndReplaceDialogModel();

            toFind.DataBindings.DefaultDataSourceUpdateMode =
                replaceTo.DataBindings.DefaultDataSourceUpdateMode =
                matchCase.DataBindings.DefaultDataSourceUpdateMode =
                useRE.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            matchCase.DataBindings.Add(nameof(CheckBox.Checked), ViewModel, nameof(ViewModel.MatchCase));
            matchWholeWord.DataBindings.Add(nameof(CheckBox.Checked), ViewModel, nameof(ViewModel.MatchWholeWord));
            useRE.DataBindings.Add(nameof(CheckBox.Checked), ViewModel, nameof(ViewModel.UseRegularExpression));
            toFind.DataBindings.Add(nameof(Text), ViewModel, nameof(ViewModel.ToFind));
            replaceTo.DataBindings.Add(nameof(Text), ViewModel, nameof(ViewModel.ReplaceTo));

            _matchCase.DataBindings.Add(nameof(CheckBox.Checked), ViewModel, nameof(ViewModel.MatchCase));
            _matchWholeWord.DataBindings.Add(nameof(CheckBox.Checked), ViewModel, nameof(ViewModel.MatchWholeWord));
            _useRE.DataBindings.Add(nameof(CheckBox.Checked), ViewModel, nameof(ViewModel.UseRegularExpression));
            _toFind.DataBindings.Add(nameof(Text), ViewModel, nameof(ViewModel.ToFind));
        }

        private void FindAndReplaceDialog_Load(object sender, EventArgs e)
        {
            Location = targetPoint;
            tabControl_CheckBtnStatus(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ToggleToFind()
        {
            tabControl.SelectTab(0);
        }

        public void ToggleToReplace()
        {
            tabControl.SelectTab(1);
        }

        public void ReplaceAll()
        {
            RichTextBox textEditor = rootNotepad.TextEditor;

            if (ViewModel.UseRegularExpression)
            {
                textEditor.Text = new Regex(ViewModel.ToFind).Replace(textEditor.Text, ViewModel.ReplaceTo);
            }
            else
            {
                RichTextBoxFinds options = RichTextBoxFinds.None;
                if (ViewModel.MatchCase)
                    options |= RichTextBoxFinds.MatchCase;
                if (ViewModel.MatchWholeWord)
                    options |= RichTextBoxFinds.WholeWord;

                int startIndex = 0, length = ViewModel.ToFind.Length;
                while (true)
                {
                    startIndex = textEditor.Find(ViewModel.ToFind, startIndex, options);
                    if (startIndex == -1)
                        break;

                    textEditor.SelectedText = ViewModel.ReplaceTo;
                    startIndex += length;
                }
            }
        }

        public void ReplaceNext()
        {
            RichTextBox textEditor = rootNotepad.TextEditor;

            if (ViewModel.UseRegularExpression)
            {
                RegexOptions regexOptions = RegexOptions.None;
                if (!ViewModel.MatchCase)
                    regexOptions |= RegexOptions.IgnoreCase;

                Regex re = new Regex(ViewModel.ToFind, regexOptions);

                if (re.Match(textEditor.Text, textEditor.SelectionStart).Index == textEditor.SelectionStart)
                {
                    textEditor.SelectedText = ViewModel.ReplaceTo;
                    re.Match(textEditor.Text, textEditor.SelectionStart + ViewModel.ReplaceTo.Length);
                }
                else
                {
                    if (!re.Match(textEditor.Text, textEditor.SelectionStart).Success)
                    {
                        MessageBox.Show("Not found", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                RichTextBoxFinds options = RichTextBoxFinds.None;
                if (ViewModel.MatchCase)
                    options |= RichTextBoxFinds.MatchCase;
                if (ViewModel.MatchWholeWord)
                    options |= RichTextBoxFinds.WholeWord;

                int searchedI = textEditor.Find(ViewModel.ToFind, textEditor.SelectionStart, options);
                if (searchedI != -1)
                {
                    FindAll();
                }
                else if (searchedI == textEditor.SelectionStart)
                {
                    textEditor.SelectedText = ViewModel.ReplaceTo;
                    textEditor.Find(ViewModel.ToFind, textEditor.SelectionStart + ViewModel.ReplaceTo.Length, options);
                }
            }
        }

        Match? findMatch;
        public bool FindAll()
        {
            RichTextBox textEditor = rootNotepad.TextEditor;
            if (ViewModel.UseRegularExpression)
            {
                RegexOptions regexOptions = RegexOptions.None;
                if (!ViewModel.MatchCase)
                    regexOptions |= RegexOptions.IgnoreCase;

                findMatch = new Regex(ViewModel.ToFind, regexOptions).Match(textEditor.Text);

                if (findMatch.Success)
                {
                    textEditor.Select(findMatch.Index, findMatch.Length);
                }
                else
                {
                    MessageBox.Show("Not found", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                RichTextBoxFinds options = RichTextBoxFinds.None;
                if (ViewModel.MatchCase)
                    options |= RichTextBoxFinds.MatchCase;
                if (ViewModel.MatchWholeWord)
                    options |= RichTextBoxFinds.WholeWord;

                if (textEditor.Find(ViewModel.ToFind, options) < 0)
                {
                    MessageBox.Show("Not found", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            return true;
        }

        public bool FindNext()
        {
            RichTextBox textEditor = rootNotepad.TextEditor;
            if (ViewModel.UseRegularExpression)
            {
                if (findMatch == null)
                {
                    FindAll();
                }
                else
                {
                    RegexOptions regexOptions = RegexOptions.None;
                    if (!ViewModel.MatchCase)
                        regexOptions |= RegexOptions.IgnoreCase;

                    findMatch = new Regex(ViewModel.ToFind, regexOptions)
                        .Match(textEditor.Text, textEditor.SelectionStart, textEditor.SelectionLength);

                    if (findMatch.Success)
                    {
                        textEditor.Select(findMatch.Index, findMatch.Length);
                    }
                    else
                    {
                        findMatch = null;
                        return FindAll();
                    }
                }
            }
            else
            {
                RichTextBoxFinds options = RichTextBoxFinds.None;
                if (ViewModel.MatchCase)
                    options |= RichTextBoxFinds.MatchCase;
                if (ViewModel.MatchWholeWord)
                    options |= RichTextBoxFinds.WholeWord;

                int startIndex = textEditor.SelectionStart + rootNotepad.TextEditor.SelectionLength;
                if (rootNotepad.TextEditor.Find(ViewModel.ToFind, startIndex, options) < 0)
                {
                    return FindAll();
                }
            }

            return true;
        }

        Point targetPoint;
        public void SetAppropriatePosition()
        {
            Location = targetPoint = MousePosition - new Size(Width / 2, Height / 2);

            int padding = 10;
            Point offLocation = Location - (Size)rootNotepad.Location;

            int newOffsetX, newOffsetY;
            if (offLocation.X < padding)
                newOffsetX = padding;
            else if (offLocation.X + Width > rootNotepad.Width - padding)
                newOffsetX = rootNotepad.Width - Width - padding;
            else
                newOffsetX = offLocation.X;

            if (offLocation.Y < padding)
                newOffsetY = padding;
            else if (offLocation.Y + Height > rootNotepad.Height - padding)
                newOffsetY = rootNotepad.Height - Height - padding;
            else
                newOffsetY = offLocation.Y;

            targetPoint = new Point(newOffsetX, newOffsetY);
            targetPoint.Offset(rootNotepad.Location);

            Location = targetPoint;
        }


        private void FindAndReplaceDialog_Shown(object sender, EventArgs e)
        {
            try
            {
                toFind.Text = Clipboard.GetText();
            }
            catch { }

            Location = targetPoint;
        }

        private void FindAndReplaceDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void findAll_Click(object sender, EventArgs e)
        {
            FindAll();
        }

        private void findNext_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void replaceAll_Click(object sender, EventArgs e)
        {
            ReplaceAll();
        }

        private void replace_Click(object sender, EventArgs e)
        {
            ReplaceNext();
        }

        private void tabControl_CheckBtnStatus(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                replaceAll.Visible = false;
                replace.Visible = false;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                replaceAll.Visible = true;
                replace.Visible = true;
            }
        }
    }
}
