using System.Windows.Forms;

namespace Null.PyNotepad
{
    partial class PyNotepad
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PyNotepad));
            this.appMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceNextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertDateAndTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setZoomValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appStatus = new System.Windows.Forms.StatusStrip();
            this.lineLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.line = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.column = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSplitter = new System.Windows.Forms.ToolStripStatusLabel();
            this.charsLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.encodingStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lineNumber = new System.Windows.Forms.Panel();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.appMenu.SuspendLayout();
            this.appStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // appMenu
            // 
            this.appMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.appMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.appMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.appMenu.Location = new System.Drawing.Point(0, 0);
            this.appMenu.Name = "appMenu";
            this.appMenu.Size = new System.Drawing.Size(1392, 33);
            this.appMenu.TabIndex = 0;
            this.appMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.pageSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(329, 6);
            // 
            // pageSettingsToolStripMenuItem
            // 
            this.pageSettingsToolStripMenuItem.Name = "pageSettingsToolStripMenuItem";
            this.pageSettingsToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.pageSettingsToolStripMenuItem.Text = "Page settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(329, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator4,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.findLastToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.replaceNextStripMenuItem,
            this.goToolStripMenuItem,
            this.toolStripSeparator5,
            this.selectAllToolStripMenuItem,
            this.dateTimeToolStripMenuItem,
            this.toolStripSeparator6,
            this.encodingToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(256, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Delete";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(256, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.findNextToolStripMenuItem.Text = "Find next";
            this.findNextToolStripMenuItem.Click += new System.EventHandler(this.findNextToolStripMenuItem_Click);
            // 
            // findLastToolStripMenuItem
            // 
            this.findLastToolStripMenuItem.Name = "findLastToolStripMenuItem";
            this.findLastToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.findLastToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.findLastToolStripMenuItem.Text = "Find last";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // replaceNextStripMenuItem
            // 
            this.replaceNextStripMenuItem.Name = "replaceNextStripMenuItem";
            this.replaceNextStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.replaceNextStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.replaceNextStripMenuItem.Text = "Replace next";
            this.replaceNextStripMenuItem.Click += new System.EventHandler(this.replaceNextStripMenuItem_Click);
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.goToolStripMenuItem.Text = "Go";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(256, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertDateAndTimeToolStripMenuItem,
            this.insertDateToolStripMenuItem,
            this.insertTimeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.dateTimeToolStripMenuItem.Text = "Date / time";
            // 
            // insertDateAndTimeToolStripMenuItem
            // 
            this.insertDateAndTimeToolStripMenuItem.Name = "insertDateAndTimeToolStripMenuItem";
            this.insertDateAndTimeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.insertDateAndTimeToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.insertDateAndTimeToolStripMenuItem.Text = "Insert date and time";
            this.insertDateAndTimeToolStripMenuItem.Click += new System.EventHandler(this.insertDateAndTimeToolStripMenuItem_Click);
            // 
            // insertDateToolStripMenuItem
            // 
            this.insertDateToolStripMenuItem.Name = "insertDateToolStripMenuItem";
            this.insertDateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.insertDateToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.insertDateToolStripMenuItem.Text = "Insert date";
            this.insertDateToolStripMenuItem.Click += new System.EventHandler(this.insertDateToolStripMenuItem_Click);
            // 
            // insertTimeToolStripMenuItem
            // 
            this.insertTimeToolStripMenuItem.Name = "insertTimeToolStripMenuItem";
            this.insertTimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.insertTimeToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.insertTimeToolStripMenuItem.Text = "Insert time";
            this.insertTimeToolStripMenuItem.Click += new System.EventHandler(this.insertTimeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(256, 6);
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.encodingToolStripMenuItem.Text = "Encoding";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.lineNumberToolStripMenuItem,
            this.wordWrapToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.resetZoomToolStripMenuItem,
            this.setZoomValueToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl++";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.zoomInToolStripMenuItem.Text = "Zoom in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+-";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.zoomOutToolStripMenuItem.Text = "Zoom out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // resetZoomToolStripMenuItem
            // 
            this.resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            this.resetZoomToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+=";
            this.resetZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemClear)));
            this.resetZoomToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.resetZoomToolStripMenuItem.Text = "Reset zoom";
            this.resetZoomToolStripMenuItem.Click += new System.EventHandler(this.resetZoomToolStripMenuItem_Click);
            // 
            // setZoomValueToolStripMenuItem
            // 
            this.setZoomValueToolStripMenuItem.Name = "setZoomValueToolStripMenuItem";
            this.setZoomValueToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.setZoomValueToolStripMenuItem.Text = "Set zoom value";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.statusBarToolStripMenuItem.Text = "Status bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // lineNumberToolStripMenuItem
            // 
            this.lineNumberToolStripMenuItem.Checked = true;
            this.lineNumberToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumberToolStripMenuItem.Name = "lineNumberToolStripMenuItem";
            this.lineNumberToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.lineNumberToolStripMenuItem.Text = "Line number";
            this.lineNumberToolStripMenuItem.Click += new System.EventHandler(this.lineNumberToolStripMenuItem_Click);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.wordWrapToolStripMenuItem.Text = "Word wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.darkModeToolStripMenuItem.Text = "Dark mode";
            // 
            // pyToolStripMenuItem
            // 
            this.pyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pythonWindowToolStripMenuItem});
            this.pyToolStripMenuItem.Name = "pyToolStripMenuItem";
            this.pyToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.pyToolStripMenuItem.Text = "Python";
            // 
            // pythonWindowToolStripMenuItem
            // 
            this.pythonWindowToolStripMenuItem.Name = "pythonWindowToolStripMenuItem";
            this.pythonWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pythonWindowToolStripMenuItem.Size = new System.Drawing.Size(298, 34);
            this.pythonWindowToolStripMenuItem.Text = "Python window";
            this.pythonWindowToolStripMenuItem.Click += new System.EventHandler(this.pythonWindowToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // appStatus
            // 
            this.appStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.appStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineLb,
            this.line,
            this.columnLb,
            this.column,
            this.statusSplitter,
            this.charsLb,
            this.charCount,
            this.splitter0,
            this.zoomStripStatusLabel,
            this.splitter1,
            this.encodingStripStatusLabel});
            this.appStatus.Location = new System.Drawing.Point(0, 848);
            this.appStatus.Name = "appStatus";
            this.appStatus.Size = new System.Drawing.Size(1392, 32);
            this.appStatus.TabIndex = 1;
            this.appStatus.Text = "statusStrip1";
            // 
            // lineLb
            // 
            this.lineLb.Name = "lineLb";
            this.lineLb.Size = new System.Drawing.Size(47, 25);
            this.lineLb.Text = "Line:";
            // 
            // line
            // 
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(22, 25);
            this.line.Text = "0";
            // 
            // columnLb
            // 
            this.columnLb.Name = "columnLb";
            this.columnLb.Size = new System.Drawing.Size(42, 25);
            this.columnLb.Text = "Col:";
            // 
            // column
            // 
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(22, 25);
            this.column.Text = "0";
            // 
            // statusSplitter
            // 
            this.statusSplitter.Name = "statusSplitter";
            this.statusSplitter.Size = new System.Drawing.Size(1029, 25);
            this.statusSplitter.Spring = true;
            // 
            // charsLb
            // 
            this.charsLb.Name = "charsLb";
            this.charsLb.Size = new System.Drawing.Size(52, 25);
            this.charsLb.Text = "Char:";
            // 
            // charCount
            // 
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(22, 25);
            this.charCount.Text = "0";
            // 
            // splitter0
            // 
            this.splitter0.Name = "splitter0";
            this.splitter0.Size = new System.Drawing.Size(16, 25);
            this.splitter0.Text = "|";
            // 
            // zoomStripStatusLabel
            // 
            this.zoomStripStatusLabel.Name = "zoomStripStatusLabel";
            this.zoomStripStatusLabel.Size = new System.Drawing.Size(57, 25);
            this.zoomStripStatusLabel.Text = "100%";
            // 
            // splitter1
            // 
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(16, 25);
            this.splitter1.Text = "|";
            // 
            // encodingStripStatusLabel
            // 
            this.encodingStripStatusLabel.Name = "encodingStripStatusLabel";
            this.encodingStripStatusLabel.Size = new System.Drawing.Size(52, 25);
            this.encodingStripStatusLabel.Text = "UTF8";
            // 
            // lineNumber
            // 
            this.lineNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lineNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineNumber.Location = new System.Drawing.Point(0, 33);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(15, 815);
            this.lineNumber.TabIndex = 2;
            // 
            // textEditor
            // 
            this.textEditor.AcceptsTab = true;
            this.textEditor.AutoWordSelection = true;
            this.textEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditor.Cursor = System.Windows.Forms.Cursors.Default;
            this.textEditor.DetectUrls = false;
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.EnableAutoDragDrop = true;
            this.textEditor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textEditor.HideSelection = false;
            this.textEditor.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textEditor.Location = new System.Drawing.Point(15, 33);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(1377, 815);
            this.textEditor.TabIndex = 3;
            this.textEditor.Text = "";
            this.textEditor.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.textEditor_LinkClicked);
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            this.textEditor.DoubleClick += new System.EventHandler(this.textEditor_DoubleClick);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "untitled.txt";
            this.openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            this.openFileDialog.Title = "OpenFile";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "untitled.txt";
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            this.saveFileDialog.Title = "Save file";
            // 
            // PyNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 880);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.lineNumber);
            this.Controls.Add(this.appStatus);
            this.Controls.Add(this.appMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.appMenu;
            this.Name = "PyNotepad";
            this.Text = "Null.PyNotepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PyNotepad_FormClosing);
            this.Load += new System.EventHandler(this.PyNotepad_Load);
            this.appMenu.ResumeLayout(false);
            this.appMenu.PerformLayout();
            this.appStatus.ResumeLayout(false);
            this.appStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip appMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertDateAndTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip appStatus;
        private System.Windows.Forms.ToolStripStatusLabel lineLb;
        private System.Windows.Forms.ToolStripStatusLabel line;
        private System.Windows.Forms.ToolStripStatusLabel columnLb;
        private System.Windows.Forms.ToolStripStatusLabel column;
        private System.Windows.Forms.ToolStripStatusLabel statusSplitter;
        private System.Windows.Forms.ToolStripStatusLabel zoomStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel splitter1;
        private System.Windows.Forms.ToolStripStatusLabel encodingStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem pyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonWindowToolStripMenuItem;
        private System.Windows.Forms.Panel lineNumber;
        private RichTextBox textEditor;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem resetZoomToolStripMenuItem;
        private ToolStripMenuItem setZoomValueToolStripMenuItem;
        private PrintDialog printDialog;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripStatusLabel charsLb;
        private ToolStripStatusLabel charCount;
        private ToolStripStatusLabel splitter0;
        private ToolStripMenuItem replaceNextStripMenuItem;
        private FontDialog fontDialog;
    }
}

