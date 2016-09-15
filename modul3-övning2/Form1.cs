using System;
using System.Windows.Forms;
using modul3_övning2.school;

namespace modul3_övning2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var course = CreateCourse();

            MessageBox.Show("Kursnamn: " + course.Name + "\nPoäng: " + course.Points + "\nStartdatum: " +
                            course.StartDate + "\nSlutdatum: " + course.EndDate);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var course = CreateCourse();

            MessageBox.Show(course.CalculateNumberOfCourseDays().ToString());
        }

        private void btnCalculatePoints_Click(object sender, EventArgs e)
        {
            var course = CreateCourse();

            MessageBox.Show("Antal poäng per dag på kursen är " + course.PointsPerCourseDay());
        }

        public Course CreateCourse()
        {
            var course = new Course
            {
                Name = txtBoxCourse.Text,
                Points = int.Parse(txtBoxPoints.Text),
                StartDate = dateStart.Value,
                EndDate = dateEnd.Value
            };

            return course;
        }
    }
}