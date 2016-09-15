using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace modul3_övning2.school
{
    public class Student
    {
        [DisplayName(@"Förnamn")]
        public string FirstName { get; set; }

        [DisplayName(@"Efternamn")]
        public string LastName { get; set; }

        [DisplayName(@"Personnummer")]
        public string Ssn { get; set; }

        [DisplayName(@"Telefon")]
        public string Phone { get; set; }

        [DisplayName(@"Email")]
        public string Email { get; set; }
        
        public Student(string firstName, string lastName, string phone, string email, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;            
            Phone = phone;
            Email = email;
            Ssn = ssn;
        }

        public string CheckValues(Student student)
        {
            var type = student.GetType();
            var props = new List<PropertyInfo>(type.GetProperties());
            var errorMessage = new StringBuilder();
            var correctMessage = new StringBuilder();
            var errors = 0;

            foreach (var property in props)
            {               
                var textbox = property.GetValue(student, null);
                var attribute = property.GetCustomAttributes(typeof (DisplayNameAttribute), true)
                                        .Cast<DisplayNameAttribute>()
                                        .FirstOrDefault();
                
                if (attribute != null)
                {
                    var displayName = attribute.DisplayName;
                    
                    if (string.IsNullOrWhiteSpace(textbox.ToString()))
                    {
                        errorMessage.Append(displayName + " får inte vara tomt.\n");
                        errors++;
                    }

                    if (errors == 0)
                    {
                        correctMessage.Append(textbox + "\n");
                    }
                }                         
            }

            if (errors == 0)
            {
                correctMessage.Insert(0, "Du har matat in följande uppgifter\n\n");
                correctMessage.Insert(correctMessage.Length, "\nStämmer det?");

                return correctMessage.ToString();
            }

            return errorMessage.ToString();
        }

        public static List<Grade> GetGrades()
        {
            var grades = CreateGrades();

            return grades;
        } 

        public static List<Grade> CreateGrades()
        {
            var grades = new List<Grade>();

            var grade1 = new Grade
            {
                Name = "Programmering C#",
                Value = "G"
            };

            var grade2 = new Grade
            {
                Name = "ASP.NET med C#",
                Value = "VG"
            };

            var grade3 = new Grade
            {
                Name = "Frontendutveckling",
                Value = "VG"
            };

            grades.Add(grade1);
            grades.Add(grade2);
            grades.Add(grade3);

            return grades;
        }
    }
}