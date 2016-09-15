namespace FileExamples
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDirectory = new System.Windows.Forms.TextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.cmdShowFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filkatalog";
            // 
            // txtBoxDirectory
            // 
            this.txtBoxDirectory.Location = new System.Drawing.Point(175, 100);
            this.txtBoxDirectory.Name = "txtBoxDirectory";
            this.txtBoxDirectory.Size = new System.Drawing.Size(552, 26);
            this.txtBoxDirectory.TabIndex = 1;
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 20;
            this.lstFiles.Location = new System.Drawing.Point(175, 149);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(552, 304);
            this.lstFiles.TabIndex = 2;
            // 
            // cmdShowFiles
            // 
            this.cmdShowFiles.Location = new System.Drawing.Point(793, 100);
            this.cmdShowFiles.Name = "cmdShowFiles";
            this.cmdShowFiles.Size = new System.Drawing.Size(215, 67);
            this.cmdShowFiles.TabIndex = 3;
            this.cmdShowFiles.Text = "Visa filer";
            this.cmdShowFiles.UseVisualStyleBackColor = true;
            this.cmdShowFiles.Click += new System.EventHandler(this.cmdShowFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 657);
            this.Controls.Add(this.cmdShowFiles);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.txtBoxDirectory);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDirectory;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button cmdShowFiles;
    }
}

