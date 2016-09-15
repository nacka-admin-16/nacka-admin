namespace modul3_övning5
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxSsn = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstBoxGrades = new System.Windows.Forms.ListBox();
            this.btnGetGrade = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(108, 84);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Förnamn";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(239, 77);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(406, 26);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(112, 155);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Efternamn";
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Location = new System.Drawing.Point(112, 243);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(117, 20);
            this.lblSsn.TabIndex = 3;
            this.lblSsn.Text = "Personnummer";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(112, 315);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Telefon";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(239, 148);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(406, 26);
            this.txtBoxLastName.TabIndex = 5;
            // 
            // txtBoxSsn
            // 
            this.txtBoxSsn.Location = new System.Drawing.Point(239, 236);
            this.txtBoxSsn.Name = "txtBoxSsn";
            this.txtBoxSsn.Size = new System.Drawing.Size(406, 26);
            this.txtBoxSsn.TabIndex = 6;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(239, 308);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(406, 26);
            this.txtBoxPhone.TabIndex = 7;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(239, 456);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(173, 59);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Visa";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(476, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 59);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Rensa";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lstBoxGrades
            // 
            this.lstBoxGrades.FormattingEnabled = true;
            this.lstBoxGrades.ItemHeight = 20;
            this.lstBoxGrades.Location = new System.Drawing.Point(696, 77);
            this.lstBoxGrades.Name = "lstBoxGrades";
            this.lstBoxGrades.Size = new System.Drawing.Size(588, 264);
            this.lstBoxGrades.TabIndex = 10;
            // 
            // btnGetGrade
            // 
            this.btnGetGrade.Location = new System.Drawing.Point(1129, 396);
            this.btnGetGrade.Name = "btnGetGrade";
            this.btnGetGrade.Size = new System.Drawing.Size(155, 49);
            this.btnGetGrade.TabIndex = 11;
            this.btnGetGrade.Text = "Hämta betyg";
            this.btnGetGrade.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(112, 381);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(239, 374);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(406, 26);
            this.txtBoxEmail.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 803);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnGetGrade);
            this.Controls.Add(this.lstBoxGrades);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxSsn);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSsn);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSsn;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxSsn;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstBoxGrades;
        private System.Windows.Forms.Button btnGetGrade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
    }
}

