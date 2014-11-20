using System;

namespace TestYourelf3CourseList
{
    class Student
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}