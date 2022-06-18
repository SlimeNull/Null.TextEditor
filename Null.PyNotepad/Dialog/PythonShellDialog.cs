using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

#nullable enable
namespace Null.PyNotepad.Dialogs
{
    public partial class PythonShellDialog : Form
    {
        private readonly PyNotepad rootNotepad;

        Lazy<ScriptEngine> scriptEngine;
        Lazy<ScriptScope> scriptScope;

        public PythonShellDialog(PyNotepad rootNotepad)
        {
            InitializeComponent();
            this.rootNotepad = rootNotepad ?? throw new ArgumentNullException(nameof(rootNotepad));

            this.runSrc.DataBindings.DefaultDataSourceUpdateMode =
                this.runRst.DataBindings.DefaultDataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;

            this.runSrc.DataBindings.Add(nameof(Font), this.rootNotepad.TextEditor, nameof(this.rootNotepad.TextEditor.Font));
            this.runRst.DataBindings.Add(nameof(Font), this.rootNotepad.TextEditor, nameof(this.rootNotepad.TextEditor.Font));

            scriptEngine = new Lazy<ScriptEngine>(() => Python.CreateEngine());
            scriptScope = new Lazy<ScriptScope>(() => scriptEngine.Value.CreateScope());

            rootNotepad.LocationChanged += RootNotepad_RectChanged;
            rootNotepad.SizeChanged += PythonShellDialog_Load;
        }

        private void PythonShellDialog_Load(object sender, EventArgs e)
        {
            RootNotepad_RectChanged(null, null);
        }

        private void RootNotepad_RectChanged(object sender, EventArgs e)
        {
            this.Location = rootNotepad.Location + new Size(rootNotepad.Width, 0);
        }

        private void SetupScope()
        {
            scriptEngine.Value.Runtime.IO.SetOutput(new NotifyWriteStream(v =>
            {
                string txt = Encoding.UTF8.GetString(v.buffer, v.offset, v.count);
                this.Invoke(() => runRst.AppendText(txt));
            }), Encoding.UTF8);

            scriptScope.Value.SetVariable("text", rootNotepad.TextEditor.Text);
            scriptScope.Value.SetVariable("lines", rootNotepad.TextEditor.Lines);
        }

        private void run_Click(object sender, EventArgs e)
        {
            SetupScope();

            runRst.Text = string.Empty;
            string runSrcTxt = runSrc.Text;

            Task.Run(() =>
            {
                try
                {
                    scriptEngine.Value.Execute(runSrcTxt, scriptScope.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.GetType()}: {ex.Message}");
                }
            });
        }

        private void runSrc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                run_Click(null, null);
            }
        }

        private void PythonShellDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        class NotifyWriteStream : Stream
        {
            public NotifyWriteStream(Action<(byte[] buffer, int offset, int count)> writeAction)
            {
                WriteAction = writeAction ?? throw new ArgumentNullException(nameof(writeAction));
            }
            public override bool CanRead => false;

            public override bool CanSeek => false;

            public override bool CanWrite => true;

            public override long Length => throw new InvalidOperationException();

            public override long Position { get => throw new InvalidOperationException(); set => throw new InvalidOperationException(); }
            public Action<(byte[] buffer, int offset, int count)> WriteAction { get; }

            public override void Flush() { }
            public override int Read(byte[] buffer, int offset, int count) => throw new InvalidOperationException();
            public override long Seek(long offset, SeekOrigin origin) => throw new InvalidOperationException();
            public override void SetLength(long value) => throw new InvalidOperationException();
            public override void Write(byte[] buffer, int offset, int count) => WriteAction((buffer, offset, count));
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"You can run python script here\n" +
                $"  to get your text in PyNotepad, use variable 'text'\n" +
                $"  to get all lines in PyNotepad, use variable 'lines'\n" +
                $"\n" +
                $"Sample script:\n" +
                $"\n" +
                $"for i in lines:\n" +
                $"  print('prefix' + i)", "Python shell help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void runSrc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
