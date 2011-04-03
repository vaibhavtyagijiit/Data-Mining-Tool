namespace CIS375_Project3
{
    partial class Main
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestCaseGb = new System.Windows.Forms.GroupBox();
            this.TestCaseBrowBtn = new System.Windows.Forms.Button();
            this.TestCaseFileTxt = new System.Windows.Forms.TextBox();
            this.CaseLibGb = new System.Windows.Forms.GroupBox();
            this.CaseLibBrowBtn = new System.Windows.Forms.Button();
            this.CaseFileTxt = new System.Windows.Forms.TextBox();
            this.ActualFaltGb = new System.Windows.Forms.GroupBox();
            this.ActualFaultBrowBtn = new System.Windows.Forms.Button();
            this.ActualFaultFileTxt = new System.Windows.Forms.TextBox();
            this.IncludeActualFaultCb = new System.Windows.Forms.CheckBox();
            this.NumModTxt = new System.Windows.Forms.TextBox();
            this.NumModLbl = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainMenuStrip.SuspendLayout();
            this.TestCaseGb.SuspendLayout();
            this.CaseLibGb.SuspendLayout();
            this.ActualFaltGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(371, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // TestCaseGb
            // 
            this.TestCaseGb.Controls.Add(this.TestCaseBrowBtn);
            this.TestCaseGb.Controls.Add(this.TestCaseFileTxt);
            this.TestCaseGb.Location = new System.Drawing.Point(12, 131);
            this.TestCaseGb.Name = "TestCaseGb";
            this.TestCaseGb.Size = new System.Drawing.Size(344, 67);
            this.TestCaseGb.TabIndex = 1;
            this.TestCaseGb.TabStop = false;
            this.TestCaseGb.Text = "Select Test Case File";
            // 
            // TestCaseBrowBtn
            // 
            this.TestCaseBrowBtn.Location = new System.Drawing.Point(252, 25);
            this.TestCaseBrowBtn.Name = "TestCaseBrowBtn";
            this.TestCaseBrowBtn.Size = new System.Drawing.Size(75, 23);
            this.TestCaseBrowBtn.TabIndex = 1;
            this.TestCaseBrowBtn.Text = "Browse";
            this.TestCaseBrowBtn.UseVisualStyleBackColor = true;
            this.TestCaseBrowBtn.Click += new System.EventHandler(this.TestCaseBrowBtn_Click);
            // 
            // TestCaseFileTxt
            // 
            this.TestCaseFileTxt.Location = new System.Drawing.Point(17, 27);
            this.TestCaseFileTxt.Name = "TestCaseFileTxt";
            this.TestCaseFileTxt.Size = new System.Drawing.Size(229, 20);
            this.TestCaseFileTxt.TabIndex = 0;
            // 
            // CaseLibGb
            // 
            this.CaseLibGb.Controls.Add(this.CaseLibBrowBtn);
            this.CaseLibGb.Controls.Add(this.CaseFileTxt);
            this.CaseLibGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseLibGb.Location = new System.Drawing.Point(12, 58);
            this.CaseLibGb.Name = "CaseLibGb";
            this.CaseLibGb.Size = new System.Drawing.Size(344, 67);
            this.CaseLibGb.TabIndex = 2;
            this.CaseLibGb.TabStop = false;
            this.CaseLibGb.Text = "Select Case Library File";
            // 
            // CaseLibBrowBtn
            // 
            this.CaseLibBrowBtn.Location = new System.Drawing.Point(252, 25);
            this.CaseLibBrowBtn.Name = "CaseLibBrowBtn";
            this.CaseLibBrowBtn.Size = new System.Drawing.Size(75, 23);
            this.CaseLibBrowBtn.TabIndex = 1;
            this.CaseLibBrowBtn.Text = "Browse";
            this.CaseLibBrowBtn.UseVisualStyleBackColor = true;
            this.CaseLibBrowBtn.Click += new System.EventHandler(this.CaseLibBrowBtn_Click);
            // 
            // CaseFileTxt
            // 
            this.CaseFileTxt.Location = new System.Drawing.Point(17, 27);
            this.CaseFileTxt.Name = "CaseFileTxt";
            this.CaseFileTxt.Size = new System.Drawing.Size(229, 20);
            this.CaseFileTxt.TabIndex = 0;
            // 
            // ActualFaltGb
            // 
            this.ActualFaltGb.Controls.Add(this.ActualFaultBrowBtn);
            this.ActualFaltGb.Controls.Add(this.ActualFaultFileTxt);
            this.ActualFaltGb.Enabled = false;
            this.ActualFaltGb.Location = new System.Drawing.Point(12, 227);
            this.ActualFaltGb.Name = "ActualFaltGb";
            this.ActualFaltGb.Size = new System.Drawing.Size(344, 67);
            this.ActualFaltGb.TabIndex = 3;
            this.ActualFaltGb.TabStop = false;
            this.ActualFaltGb.Text = "Select Actual Fault File";
            // 
            // ActualFaultBrowBtn
            // 
            this.ActualFaultBrowBtn.Enabled = false;
            this.ActualFaultBrowBtn.Location = new System.Drawing.Point(252, 25);
            this.ActualFaultBrowBtn.Name = "ActualFaultBrowBtn";
            this.ActualFaultBrowBtn.Size = new System.Drawing.Size(75, 23);
            this.ActualFaultBrowBtn.TabIndex = 1;
            this.ActualFaultBrowBtn.Text = "Browse";
            this.ActualFaultBrowBtn.UseVisualStyleBackColor = true;
            this.ActualFaultBrowBtn.Click += new System.EventHandler(this.ActualFaultBrowBtn_Click);
            // 
            // ActualFaultFileTxt
            // 
            this.ActualFaultFileTxt.Enabled = false;
            this.ActualFaultFileTxt.Location = new System.Drawing.Point(17, 27);
            this.ActualFaultFileTxt.Name = "ActualFaultFileTxt";
            this.ActualFaultFileTxt.Size = new System.Drawing.Size(229, 20);
            this.ActualFaultFileTxt.TabIndex = 0;
            // 
            // IncludeActualFaultCb
            // 
            this.IncludeActualFaultCb.AutoSize = true;
            this.IncludeActualFaultCb.Location = new System.Drawing.Point(12, 204);
            this.IncludeActualFaultCb.Name = "IncludeActualFaultCb";
            this.IncludeActualFaultCb.Size = new System.Drawing.Size(139, 17);
            this.IncludeActualFaultCb.TabIndex = 4;
            this.IncludeActualFaultCb.Text = "Include Actual Fault File";
            this.IncludeActualFaultCb.UseVisualStyleBackColor = true;
            this.IncludeActualFaultCb.CheckedChanged += new System.EventHandler(this.IncludeActualFaultCb_CheckedChanged);
            // 
            // NumModTxt
            // 
            this.NumModTxt.Location = new System.Drawing.Point(188, 32);
            this.NumModTxt.Name = "NumModTxt";
            this.NumModTxt.Size = new System.Drawing.Size(151, 20);
            this.NumModTxt.TabIndex = 5;
            // 
            // NumModLbl
            // 
            this.NumModLbl.AutoSize = true;
            this.NumModLbl.Location = new System.Drawing.Point(26, 35);
            this.NumModLbl.Name = "NumModLbl";
            this.NumModLbl.Size = new System.Drawing.Size(156, 13);
            this.NumModLbl.TabIndex = 6;
            this.NumModLbl.Text = "Number of Modules to Compare";
            //this.NumModLbl.Click += new System.EventHandler(this.NumModLbl_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(264, 304);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(183, 304);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select File";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(157, 204);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(199, 23);
            this.ProgressBar.TabIndex = 9;
            this.ProgressBar.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 339);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.NumModLbl);
            this.Controls.Add(this.NumModTxt);
            this.Controls.Add(this.IncludeActualFaultCb);
            this.Controls.Add(this.ActualFaltGb);
            this.Controls.Add(this.CaseLibGb);
            this.Controls.Add(this.TestCaseGb);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "Main";
            this.Text = "Data Mining Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.TestCaseGb.ResumeLayout(false);
            this.TestCaseGb.PerformLayout();
            this.CaseLibGb.ResumeLayout(false);
            this.CaseLibGb.PerformLayout();
            this.ActualFaltGb.ResumeLayout(false);
            this.ActualFaltGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox TestCaseGb;
        private System.Windows.Forms.Button TestCaseBrowBtn;
        private System.Windows.Forms.TextBox TestCaseFileTxt;
        private System.Windows.Forms.GroupBox CaseLibGb;
        private System.Windows.Forms.Button CaseLibBrowBtn;
        private System.Windows.Forms.TextBox CaseFileTxt;
        private System.Windows.Forms.GroupBox ActualFaltGb;
        private System.Windows.Forms.Button ActualFaultBrowBtn;
        private System.Windows.Forms.TextBox ActualFaultFileTxt;
        private System.Windows.Forms.CheckBox IncludeActualFaultCb;
        private System.Windows.Forms.TextBox NumModTxt;
        private System.Windows.Forms.Label NumModLbl;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

