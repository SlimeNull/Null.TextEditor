namespace Null.PyNotepad.Dialogs
{
    partial class FindAndReplaceDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pg_find = new System.Windows.Forms.TabPage();
            this.useRE = new System.Windows.Forms.CheckBox();
            this.matchWholeWord = new System.Windows.Forms.CheckBox();
            this.matchCase = new System.Windows.Forms.CheckBox();
            this.toFind = new System.Windows.Forms.TextBox();
            this.toFindLb = new System.Windows.Forms.Label();
            this.pg_replace = new System.Windows.Forms.TabPage();
            this._useRE = new System.Windows.Forms.CheckBox();
            this.useReVars = new System.Windows.Forms.CheckBox();
            this._matchWholeWord = new System.Windows.Forms.CheckBox();
            this._matchCase = new System.Windows.Forms.CheckBox();
            this.replaceTo = new System.Windows.Forms.TextBox();
            this._toFind = new System.Windows.Forms.TextBox();
            this.replaceToLb = new System.Windows.Forms.Label();
            this._toFindLb = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.findNext = new System.Windows.Forms.Button();
            this.findAll = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.Button();
            this.replaceAll = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.pg_find.SuspendLayout();
            this.pg_replace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.pg_find);
            this.tabControl.Controls.Add(this.pg_replace);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(564, 199);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_CheckBtnStatus);
            // 
            // pg_find
            // 
            this.pg_find.Controls.Add(this.useRE);
            this.pg_find.Controls.Add(this.matchWholeWord);
            this.pg_find.Controls.Add(this.matchCase);
            this.pg_find.Controls.Add(this.toFind);
            this.pg_find.Controls.Add(this.toFindLb);
            this.pg_find.Location = new System.Drawing.Point(4, 29);
            this.pg_find.Name = "pg_find";
            this.pg_find.Padding = new System.Windows.Forms.Padding(10);
            this.pg_find.Size = new System.Drawing.Size(556, 166);
            this.pg_find.TabIndex = 0;
            this.pg_find.Text = "Find";
            this.pg_find.UseVisualStyleBackColor = true;
            // 
            // useRE
            // 
            this.useRE.AutoSize = true;
            this.useRE.Location = new System.Drawing.Point(332, 49);
            this.useRE.Margin = new System.Windows.Forms.Padding(3, 8, 15, 3);
            this.useRE.Name = "useRE";
            this.useRE.Size = new System.Drawing.Size(197, 24);
            this.useRE.TabIndex = 2;
            this.useRE.Text = "Use regular expression";
            this.useRE.UseVisualStyleBackColor = true;
            // 
            // matchWholeWord
            // 
            this.matchWholeWord.AutoSize = true;
            this.matchWholeWord.Location = new System.Drawing.Point(152, 49);
            this.matchWholeWord.Margin = new System.Windows.Forms.Padding(3, 8, 15, 3);
            this.matchWholeWord.Name = "matchWholeWord";
            this.matchWholeWord.Size = new System.Drawing.Size(162, 24);
            this.matchWholeWord.TabIndex = 2;
            this.matchWholeWord.Text = "Match whole word";
            this.matchWholeWord.UseVisualStyleBackColor = true;
            // 
            // matchCase
            // 
            this.matchCase.AutoSize = true;
            this.matchCase.Location = new System.Drawing.Point(17, 49);
            this.matchCase.Margin = new System.Windows.Forms.Padding(3, 8, 15, 3);
            this.matchCase.Name = "matchCase";
            this.matchCase.Size = new System.Drawing.Size(117, 24);
            this.matchCase.TabIndex = 2;
            this.matchCase.Text = "Match case";
            this.matchCase.UseVisualStyleBackColor = true;
            // 
            // toFind
            // 
            this.toFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toFind.Location = new System.Drawing.Point(63, 12);
            this.toFind.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.toFind.Name = "toFind";
            this.toFind.Size = new System.Drawing.Size(480, 26);
            this.toFind.TabIndex = 1;
            // 
            // toFindLb
            // 
            this.toFindLb.AutoSize = true;
            this.toFindLb.Location = new System.Drawing.Point(13, 15);
            this.toFindLb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.toFindLb.Name = "toFindLb";
            this.toFindLb.Size = new System.Drawing.Size(44, 20);
            this.toFindLb.TabIndex = 0;
            this.toFindLb.Text = "Find:";
            // 
            // pg_replace
            // 
            this.pg_replace.Controls.Add(this._useRE);
            this.pg_replace.Controls.Add(this.useReVars);
            this.pg_replace.Controls.Add(this._matchWholeWord);
            this.pg_replace.Controls.Add(this._matchCase);
            this.pg_replace.Controls.Add(this.replaceTo);
            this.pg_replace.Controls.Add(this._toFind);
            this.pg_replace.Controls.Add(this.replaceToLb);
            this.pg_replace.Controls.Add(this._toFindLb);
            this.pg_replace.Location = new System.Drawing.Point(4, 29);
            this.pg_replace.Name = "pg_replace";
            this.pg_replace.Padding = new System.Windows.Forms.Padding(3);
            this.pg_replace.Size = new System.Drawing.Size(556, 166);
            this.pg_replace.TabIndex = 1;
            this.pg_replace.Text = "Replace";
            this.pg_replace.UseVisualStyleBackColor = true;
            // 
            // _useRE
            // 
            this._useRE.AutoSize = true;
            this._useRE.Location = new System.Drawing.Point(332, 49);
            this._useRE.Margin = new System.Windows.Forms.Padding(3, 8, 15, 3);
            this._useRE.Name = "_useRE";
            this._useRE.Size = new System.Drawing.Size(197, 24);
            this._useRE.TabIndex = 5;
            this._useRE.Text = "Use regular expression";
            this._useRE.UseVisualStyleBackColor = true;
            // 
            // useReVars
            // 
            this.useReVars.AutoSize = true;
            this.useReVars.Location = new System.Drawing.Point(17, 109);
            this.useReVars.Margin = new System.Windows.Forms.Padding(3, 8, 15, 3);
            this.useReVars.Name = "useReVars";
            this.useReVars.Size = new System.Drawing.Size(263, 24);
            this.useReVars.TabIndex = 6;
            this.useReVars.Text = "Use regular expression variables";
            this.useReVars.UseVisualStyleBackColor = true;
            // 
            // _matchWholeWord
            // 
            this._matchWholeWord.AutoSize = true;
            this._matchWholeWord.Location = new System.Drawing.Point(152, 49);
            this._matchWholeWord.Margin = new System.Windows.Forms.Padding(3, 8, 15, 3);
            this._matchWholeWord.Name = "_matchWholeWord";
            this._matchWholeWord.Size = new System.Drawing.Size(162, 24);
            this._matchWholeWord.TabIndex = 6;
            this._matchWholeWord.Text = "Match whole word";
            this._matchWholeWord.UseVisualStyleBackColor = true;
            // 
            // _matchCase
            // 
            this._matchCase.AutoSize = true;
            this._matchCase.Location = new System.Drawing.Point(17, 49);
            this._matchCase.Margin = new System.Windows.Forms.Padding(3, 8, 15, 3);
            this._matchCase.Name = "_matchCase";
            this._matchCase.Size = new System.Drawing.Size(117, 24);
            this._matchCase.TabIndex = 6;
            this._matchCase.Text = "Match case";
            this._matchCase.UseVisualStyleBackColor = true;
            // 
            // replaceTo
            // 
            this.replaceTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceTo.Location = new System.Drawing.Point(114, 78);
            this.replaceTo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.replaceTo.Name = "replaceTo";
            this.replaceTo.Size = new System.Drawing.Size(429, 26);
            this.replaceTo.TabIndex = 4;
            // 
            // _toFind
            // 
            this._toFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._toFind.Location = new System.Drawing.Point(63, 12);
            this._toFind.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this._toFind.Name = "_toFind";
            this._toFind.Size = new System.Drawing.Size(480, 26);
            this._toFind.TabIndex = 4;
            // 
            // replaceToLb
            // 
            this.replaceToLb.AutoSize = true;
            this.replaceToLb.Location = new System.Drawing.Point(13, 81);
            this.replaceToLb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.replaceToLb.Name = "replaceToLb";
            this.replaceToLb.Size = new System.Drawing.Size(90, 20);
            this.replaceToLb.TabIndex = 3;
            this.replaceToLb.Text = "Replace to:";
            // 
            // _toFindLb
            // 
            this._toFindLb.AutoSize = true;
            this._toFindLb.Location = new System.Drawing.Point(13, 15);
            this._toFindLb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this._toFindLb.Name = "_toFindLb";
            this._toFindLb.Size = new System.Drawing.Size(44, 20);
            this._toFindLb.TabIndex = 3;
            this._toFindLb.Text = "Find:";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Location = new System.Drawing.Point(469, 217);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(107, 40);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // findNext
            // 
            this.findNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findNext.Location = new System.Drawing.Point(356, 217);
            this.findNext.Name = "findNext";
            this.findNext.Size = new System.Drawing.Size(107, 40);
            this.findNext.TabIndex = 1;
            this.findNext.Text = "Find next";
            this.findNext.UseVisualStyleBackColor = true;
            this.findNext.Click += new System.EventHandler(this.findNext_Click);
            // 
            // findAll
            // 
            this.findAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findAll.Location = new System.Drawing.Point(243, 217);
            this.findAll.Name = "findAll";
            this.findAll.Size = new System.Drawing.Size(107, 40);
            this.findAll.TabIndex = 1;
            this.findAll.Text = "Find all";
            this.findAll.UseVisualStyleBackColor = true;
            this.findAll.Click += new System.EventHandler(this.findAll_Click);
            // 
            // replace
            // 
            this.replace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.replace.Location = new System.Drawing.Point(123, 217);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(114, 40);
            this.replace.TabIndex = 1;
            this.replace.Text = "Replace next";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // replaceAll
            // 
            this.replaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceAll.Location = new System.Drawing.Point(17, 217);
            this.replaceAll.Name = "replaceAll";
            this.replaceAll.Size = new System.Drawing.Size(100, 40);
            this.replaceAll.TabIndex = 1;
            this.replaceAll.Text = "Replace all";
            this.replaceAll.UseVisualStyleBackColor = true;
            this.replaceAll.Click += new System.EventHandler(this.replaceAll_Click);
            // 
            // FindAndReplaceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(588, 269);
            this.Controls.Add(this.replaceAll);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.findAll);
            this.Controls.Add(this.findNext);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(610, 325);
            this.Name = "FindAndReplaceDialog";
            this.Text = "Find and replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindAndReplaceDialog_FormClosing);
            this.Load += new System.EventHandler(this.FindAndReplaceDialog_Load);
            this.Shown += new System.EventHandler(this.FindAndReplaceDialog_Shown);
            this.tabControl.ResumeLayout(false);
            this.pg_find.ResumeLayout(false);
            this.pg_find.PerformLayout();
            this.pg_replace.ResumeLayout(false);
            this.pg_replace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pg_find;
        private System.Windows.Forms.Label toFindLb;
        private System.Windows.Forms.TabPage pg_replace;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button findNext;
        private System.Windows.Forms.Button findAll;
        private System.Windows.Forms.CheckBox useRE;
        private System.Windows.Forms.CheckBox matchCase;
        private System.Windows.Forms.TextBox toFind;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button replaceAll;
        private System.Windows.Forms.CheckBox _useRE;
        private System.Windows.Forms.CheckBox _matchCase;
        private System.Windows.Forms.TextBox replaceTo;
        private System.Windows.Forms.TextBox _toFind;
        private System.Windows.Forms.Label replaceToLb;
        private System.Windows.Forms.Label _toFindLb;
        private System.Windows.Forms.CheckBox useReVars;
        private System.Windows.Forms.CheckBox matchWholeWord;
        private System.Windows.Forms.CheckBox _matchWholeWord;
    }
}