using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_UI_Sachi.Models
{
    public class Student
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ImageThumbnail { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public double GPA { get; set; }

        public Student()
        {
        }

        public Student(string firstName, string lastName, string imageThumbnail, DateTime dateOfBirth, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            ImageThumbnail = imageThumbnail;
            DateOfBirth = dateOfBirth;
            GPA = gpa;
        }
    }
}
