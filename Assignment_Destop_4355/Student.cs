using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Destop_4355
{
    public class Student
    {
        public int Age { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string GPA { get; set; }

        public string Image { get; set; }

        public string ImageURL
        {
            get
            { return $"/Images/{Image}"; }
        }




        public Student(int age,
                       string firstName,
                       string lastName,
                       string dateOfBirth,
                       string GPA,
                       string image)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            this.GPA = GPA;
            Image = image;
        }

        public Student()
        {

        }
    }
}
