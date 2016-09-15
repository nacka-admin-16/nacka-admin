using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modul3_övning5.Entities;

namespace modul3_övning5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var firstName = txtBoxFirstName.Text;
            var lastName = txtBoxLastName.Text;
            var ssn = txtBoxSsn.Text;
            var phone = txtBoxPhone.Text;
            var email = txtBoxEmail.Text;

            var student = new Student(firstName, lastName, ssn, phone, email);

            student.CheckValues(student);

            MessageBox.Show("");
        }
    }
}