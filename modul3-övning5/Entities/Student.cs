using System.Collections.Generic;
using System.Reflection;

namespace modul3_övning5.Entities
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Ssn { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Student(string firstName, string lastName, string ssn, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
            Phone = phone;
            Email = email;
        }

        public string CheckValues(Student student)
        {
            var myType = student.GetType();
            var props = new List<PropertyInfo>(myType.GetProperties());

            foreach (var property in props)
            {
                var obj  = property.GetValue(student, null) as string;

                if (string.IsNullOrWhiteSpace(obj))
                {
                }
            }

            return string.Empty;
        }
    }
}