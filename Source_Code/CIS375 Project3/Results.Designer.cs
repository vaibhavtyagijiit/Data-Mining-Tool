namespace CIS375_Project3
{
    partial class Results
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StdDevTxt = new System.Windows.Forms.Label();
            this.MeanSqrdTxt = new System.Windows.Forms.Label();
            this.StdDevLbl = new System.Windows.Forms.Label();
            this.MeanSqarLbl = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StdDevTxt);
            this.groupBox1.Controls.Add(this.MeanSqrdTxt);
            this.groupBox1.Controls.Add(this.StdDevLbl);
            this.groupBox1.Controls.Add(this.MeanSqarLbl);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predicted vs Actual Fault Statistics";
            // 
            // StdDevTxt
            // 
            this.StdDevTxt.AutoSize = true;
            this.StdDevTxt.Location = new System.Drawing.Point(116, 47);
            this.StdDevTxt.Name = "StdDevTxt";
            this.StdDevTxt.Size = new System.Drawing.Size(35, 13);
            this.StdDevTxt.TabIndex = 3;
            this.StdDevTxt.Text = "label4";
            // 
            // MeanSqrdTxt
            // 
            this.MeanSqrdTxt.AutoSize = true;
            this.MeanSqrdTxt.Location = new System.Drawing.Point(116, 25);
            this.MeanSqrdTxt.Name = "MeanSqrdTxt";
            this.MeanSqrdTxt.Size = new System.Drawing.Size(35, 13);
            this.MeanSqrdTxt.TabIndex = 2;
            this.MeanSqrdTxt.Text = "label3";
            // 
            // StdDevLbl
            // 
            this.StdDevLbl.AutoSize = true;
            this.StdDevLbl.Location = new System.Drawing.Point(6, 47);
            this.StdDevLbl.Name = "StdDevLbl";
            this.StdDevLbl.Size = new System.Drawing.Size(104, 13);
            this.StdDevLbl.TabIndex = 1;
            this.StdDevLbl.Text = "Standard Deviation: ";
            // 
            // MeanSqarLbl
            // 
            this.MeanSqarLbl.AutoSize = true;
            this.MeanSqarLbl.Location = new System.Drawing.Point(6, 25);
            this.MeanSqarLbl.Name = "MeanSqarLbl";
            this.MeanSqarLbl.Size = new System.Drawing.Size(80, 13);
            this.MeanSqarLbl.TabIndex = 0;
            this.MeanSqarLbl.Text = "Mean-Squared:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(31, 113);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(911, 277);
            this.listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Predicted Faults";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Module";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label StdDevLbl;
        private System.Windows.Forms.Label MeanSqarLbl;
        private System.Windows.Forms.Label StdDevTxt;
        private System.Windows.Forms.Label MeanSqrdTxt;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}