using Microsoft.Scripting.Hosting;
using Microsoft.Win32;
using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Null.Library.TriggerStream;
using Microsoft.Scripting;

namespace TextEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ScriptEngine engine;
        ScriptScope scope;

        public MainWindow()
        {
            InitializeComponent();

            TriggerStream triggerStream = new TriggerStream();
            triggerStream.PreviewWrite += TriggerStream_PreviewWrite;

            engine = Python.CreateEngine();
            scope = engine.CreateScope();
            EngineInitialize();
            engine.Runtime.IO.SetOutput(triggerStream, Encoding.Default);

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
        void EngineInitialize()
        {
            try
            {
                string[] paths = Environment.GetEnvironmentVariable("Path").Split(';');
                List<string> searchPaths = new List<string>();
                foreach(string i in paths)
                {
                    searchPaths.Add(i);
                    if (i.ToLower().Contains("python"))
                        searchPaths.Add(System.IO.Path.Combine(i, "Lib"));
                }
                searchPaths.Add(".");
                searchPaths.Add("./Lib");
                engine.SetSearchPaths(searchPaths);

                
            }
            catch { }
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                Dispatcher.Invoke(() =>
                {
                    if (AutoGet.IsChecked.GetValueOrDefault(false))
                        GetVar();
                });
            }
            catch { }
        }

        private void TriggerStream_PreviewWrite(object sender, WriteStreamEventArgs e)
        {
            string qwq;
            try
            {
                qwq = Encoding.Default.GetString(e.Buffer, e.Offset, e.Count);
                Dispatcher.Invoke(()=>
                {
                    OutputBox.AppendText(qwq);
                });
            }
            catch { }
        }

        int varnameIndex;
        string varname;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void FieldName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Regex.IsMatch(FieldName.Text, @"^[A-Za-z_]*[A-Za-z0-9_]*$"))
            {
                FieldName.Text = varname;

                FieldName.CaretIndex = varnameIndex;
            }

            varnameIndex = FieldName.CaretIndex;
            varname = FieldName.Text;
        }
        Thread scriptThread;
        void RunScript(string src)
        {
            ScriptSource thisSrc = engine.CreateScriptSourceFromString(src, SourceCodeKind.File);

            if (scriptThread != null)
            {
                if (scriptThread.IsAlive)
                    scriptThread.Abort();
                GC.ReRegisterForFinalize(scriptThread);
            }

            OutputBox.Clear();

            scriptThread = new Thread(() =>
            {
                try
                {
                    thisSrc.Execute(scope);
                    Dispatcher.Invoke(()=>
                    {
                        GetVar();
                    });
                }
                catch (Exception e)
                {
                    Dispatcher.Invoke(()=>
                    {
                        OutputBox.AppendText($"{e.GetType()}:\n    {e.Message}\n");
                    });
                }
            });

            scriptThread.Start();
        }
        private void CodeBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if ((Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && e.Key == Key.Enter)
            {
                RunScript(CodeBox.Text);
                e.Handled = true;
            }
        }

        private void SetVar()
        {
            try
            {
                scope.SetVariable(FieldName.Text, TextSource.Text);
            }
            catch { }
        }
        private void GetVar()
        {
            try
            {
                if (scope.ContainsVariable(FieldName.Text))
                    TextSource.Text = scope.GetVariable(FieldName.Text).ToString();
            }
            catch { }
        }
        private void DelVar()
        {
            try
            {
                foreach (string name in scope.GetVariableNames())
                    scope.RemoveVariable(name);
            }
            catch { }
        }
        private void TextSource_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (AutoSet.IsChecked.GetValueOrDefault(false))
                SetVar();
        }

        private void OutputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OutputBox.ScrollToEnd();
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            RunScript(CodeBox.Text);
        }

        private void LabelSetVar(object sender, MouseButtonEventArgs e)
        {
            SetVar();
        }

        private void LabelGetVar(object sender, MouseButtonEventArgs e)
        {
            GetVar();
        }

        private void LabelDelVar(object sender, MouseButtonEventArgs e)
        {
            DelVar();
        }

        OpenFileDialog ofd;
        private void LabelModuleImport(object sender, MouseButtonEventArgs e)
        {
            if (ofd == null)
                ofd = new OpenFileDialog();

            ofd.Filter = "IronPython 脚本|*.py";
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog().GetValueOrDefault(false))
            {
                try
                {
                    engine.ExecuteFile(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.GetType()}:\n    {ex.Message}", "执行失败", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}