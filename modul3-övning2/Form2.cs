using System;
using System.Linq;
using System.Windows.Forms;
using modul3_övning2.school;

namespace modul3_övning2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstName = txtBoxFirstName.Text;
            var lastName = txtBoxLastName.Text;
            var ssn = txtBoxSsn.Text;
            var phone = txtBoxPhone.Text;
            var email = txtBoxEmail.Text;

            var student = new Student(firstName, lastName, phone, email, ssn);
            //var message = student.CheckValues(student);
            //MessageBox.Show(message);

            var formShowStudentInfo = new FormShowStudentInfo(student);
            formShowStudentInfo.Show();
        }

        private void btnGetGrades_Click(object sender, EventArgs e)
        {
            var grades = Student.GetGrades();

            foreach (var grade in grades)
            {
                lstBoxGrades.Items.Add(grade.Name + ", " + grade.Value);
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
        }
    }
}