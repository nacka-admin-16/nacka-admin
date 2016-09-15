using System.Windows.Forms;
using modul3_övning2.school;

namespace modul3_övning2
{
    public partial class FormShowStudentInfo : Form
    {
        public FormShowStudentInfo(Student student)
        {
            InitializeComponent();

            lblFirstName.Text = student.FirstName;
            lblLastName.Text = student.LastName;
            lblSsn.Text = student.Ssn;
            lblPhone.Text = student.Phone;
            lblEmail.Text = student.Email;
        }
    }
}