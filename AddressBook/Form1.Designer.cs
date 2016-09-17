namespace AddressBook
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.lblContacts = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lstBoxContacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(145, 75);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(580, 26);
            this.txtBoxName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gatuadress";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(145, 173);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(580, 26);
            this.txtBoxAddress.TabIndex = 1;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(380, 260);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(345, 26);
            this.txtBoxCity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Postort";
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(145, 260);
            this.txtBoxZip.MaxLength = 5;
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(159, 26);
            this.txtBoxZip.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Postnummer";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(145, 440);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(580, 26);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-post";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(145, 342);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(580, 26);
            this.txtBoxPhone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefon";
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Location = new System.Drawing.Point(145, 527);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(580, 46);
            this.btnSaveContact.TabIndex = 11;
            this.btnSaveContact.Text = "Spara kontakt";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(145, 624);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 12;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(854, 527);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(621, 46);
            this.btnDeleteContact.TabIndex = 14;
            this.btnDeleteContact.Text = "Radera kontakt";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Location = new System.Drawing.Point(854, 150);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(78, 20);
            this.lblContacts.TabIndex = 15;
            this.lblContacts.Text = "Kontakter";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(858, 75);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(613, 26);
            this.txtBoxSearch.TabIndex = 16;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(854, 51);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(37, 20);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Sök";
            // 
            // lstBoxContacts
            // 
            this.lstBoxContacts.FormattingEnabled = true;
            this.lstBoxContacts.ItemHeight = 20;
            this.lstBoxContacts.Location = new System.Drawing.Point(858, 173);
            this.lstBoxContacts.Name = "lstBoxContacts";
            this.lstBoxContacts.Size = new System.Drawing.Size(613, 284);
            this.lstBoxContacts.TabIndex = 21;
            this.lstBoxContacts.SelectedIndexChanged += new System.EventHandler(this.lstBoxContacts_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 1025);
            this.Controls.Add(this.lstBoxContacts);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSaveContact);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxZip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListBox lstBoxContacts;
    }
}

