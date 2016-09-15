namespace modul3_övning2.school
{
    public class Teacher
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string[] ResponsibleForCourses()
        {
            return GetCourses();
        }

        private string[] GetCourses()
        {
            var courses = new [] { "Front-end programmering", "Webbintroduktion", "Programmering C#"};

            return courses;
        }
    }
}