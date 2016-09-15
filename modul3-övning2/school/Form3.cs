using System;
using System.Text;
using System.Windows.Forms;

namespace modul3_övning2.school
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var responsibleForCourses = new Teacher().ResponsibleForCourses();
            var sb = new StringBuilder();

            foreach (var courses in responsibleForCourses)
            {
                sb.Append(courses + "\n");
            }

            MessageBox.Show(sb.ToString());
        }
    }
}