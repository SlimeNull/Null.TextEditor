namespace Null.PyNotepad.Dialogs
{
    partial class PythonShellDialog
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
            this.components = new System.ComponentModel.Container();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.uppanel = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.runSrc = new System.Windows.Forms.RichTextBox();
            this.downpanel = new System.Windows.Forms.Panel();
            this.runRst = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayout.SuspendLayout();
            this.uppanel.SuspendLayout();
            this.downpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.uppanel, 0, 0);
            this.tableLayout.Controls.Add(this.downpanel, 0, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(815, 928);
            this.tableLayout.TabIndex = 0;
            // 
            // uppanel
            // 
            this.uppanel.Controls.Add(this.close);
            this.uppanel.Controls.Add(this.help);
            this.uppanel.Controls.Add(this.run);
            this.uppanel.Controls.Add(this.runSrc);
            this.uppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uppanel.Location = new System.Drawing.Point(3, 3);
            this.uppanel.Name = "uppanel";
            this.uppanel.Size = new System.Drawing.Size(809, 458);
            this.uppanel.TabIndex = 0;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Location = new System.Drawing.Point(548, 408);
            this.close.Margin = new System.Windows.Forms.Padding(5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 40);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Visible = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.help.Location = new System.Drawing.Point(633, 408);
            this.help.Margin = new System.Windows.Forms.Padding(5);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 40);
            this.help.TabIndex = 0;
            this.help.Text = "Help";
            this.toolTip.SetToolTip(this.help, "Show help");
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // run
            // 
            this.run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.run.Location = new System.Drawing.Point(718, 408);
            this.run.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 40);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.toolTip.SetToolTip(this.run, "Run code");
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // runSrc
            // 
            this.runSrc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.runSrc.DetectUrls = false;
            this.runSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runSrc.Location = new System.Drawing.Point(0, 0);
            this.runSrc.Name = "runSrc";
            this.runSrc.Size = new System.Drawing.Size(809, 458);
            this.runSrc.TabIndex = 1;
            this.runSrc.Text = "";
            this.runSrc.WordWrap = false;
            this.runSrc.TextChanged += new System.EventHandler(this.runSrc_TextChanged);
            this.runSrc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.runSrc_KeyDown);
            // 
            // downpanel
            // 
            this.downpanel.Controls.Add(this.runRst);
            this.downpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downpanel.Location = new System.Drawing.Point(3, 467);
            this.downpanel.Name = "downpanel";
            this.downpanel.Size = new System.Drawing.Size(809, 458);
            this.downpanel.TabIndex = 1;
            // 
            // runRst
            // 
            this.runRst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.runRst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.runRst.DetectUrls = false;
            this.runRst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runRst.ForeColor = System.Drawing.Color.Black;
            this.runRst.Location = new System.Drawing.Point(0, 0);
            this.runRst.Name = "runRst";
            this.runRst.ReadOnly = true;
            this.runRst.Size = new System.Drawing.Size(809, 458);
            this.runRst.TabIndex = 0;
            this.runRst.Text = "";
            this.runRst.WordWrap = false;
            // 
            // PythonShellDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(815, 928);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "PythonShellDialog";
            this.Text = "Python shell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PythonShellDialog_FormClosing);
            this.Load += new System.EventHandler(this.PythonShellDialog_Load);
            this.tableLayout.ResumeLayout(false);
            this.uppanel.ResumeLayout(false);
            this.downpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel uppanel;
        private System.Windows.Forms.Panel downpanel;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.RichTextBox runSrc;
        private System.Windows.Forms.RichTextBox runRst;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ToolTip toolTip;
    }
}