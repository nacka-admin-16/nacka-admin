using System;

namespace modul3_övning2.school
{
    public class Course
    {        
        public string Name { get; set; }

        public int Points { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double CalculateNumberOfCourseDays()
        {
            var endDays = EndDate.Date.AddDays(1).ToOADate();
            var startDays = StartDate.Date.ToOADate();

            return endDays-startDays;
        }

        public float PointsPerCourseDay()
        {
            var numberOfDays = CalculateNumberOfCourseDays();

            return (float) (Points / numberOfDays);
        }
    }
}