namespace modul3_övning2
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
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtBoxPoints = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCalculatePoints = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxCourse
            // 
            this.txtBoxCourse.Location = new System.Drawing.Point(341, 46);
            this.txtBoxCourse.Name = "txtBoxCourse";
            this.txtBoxCourse.Size = new System.Drawing.Size(650, 26);
            this.txtBoxCourse.TabIndex = 0;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(194, 51);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(81, 20);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Kursnamn";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(198, 120);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(95, 20);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Antal poäng";
            // 
            // txtBoxPoints
            // 
            this.txtBoxPoints.Location = new System.Drawing.Point(341, 120);
            this.txtBoxPoints.Name = "txtBoxPoints";
            this.txtBoxPoints.Size = new System.Drawing.Size(653, 26);
            this.txtBoxPoints.TabIndex = 3;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(198, 186);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(89, 20);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Startdatum";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(341, 179);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 26);
            this.dateStart.TabIndex = 5;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(341, 254);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 26);
            this.dateEnd.TabIndex = 6;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(202, 259);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(82, 20);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "Slutdatum";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(206, 340);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(212, 62);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Visa";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalculatePoints
            // 
            this.btnCalculatePoints.Location = new System.Drawing.Point(531, 340);
            this.btnCalculatePoints.Name = "btnCalculatePoints";
            this.btnCalculatePoints.Size = new System.Drawing.Size(203, 62);
            this.btnCalculatePoints.TabIndex = 9;
            this.btnCalculatePoints.Text = "Beräkna poäng";
            this.btnCalculatePoints.UseVisualStyleBackColor = true;
            this.btnCalculatePoints.Click += new System.EventHandler(this.btnCalculatePoints_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(824, 340);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(170, 62);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Beräkna";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 943);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnCalculatePoints);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtBoxPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtBoxCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtBoxPoints;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCalculatePoints;
        private System.Windows.Forms.Button btnCalculate;
    }
}

