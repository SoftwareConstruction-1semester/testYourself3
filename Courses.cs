using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestYourelf3CourseList
{
    class Courses
    {
        //TODO: add comments to all methods

        private List<Course> _courses = new List<Course>();

        public void PresentCourses()
        {
            //TODO: print list of valid courses and (in columns?)
        }

        public void PresentCoursesWithParticipants()
        {
            //TODO: print all courses includein name, description and participants
        }

        public bool AddCourse(String courseName, String courseDescription, int maxNumberOfParticipants)
        {
            //TODO add courses to list
        }


        public bool AddCourse(Course course)
        {
            //TODO add courses to list
        }

        public bool RemoveCourse(Course course)
        {
            //TODO: remove course from list
        }

        public bool RemoveCourse(String name)
        {
            //TODO: remove course from list
        }

        public Course GetCourse(String CourseName)
        {
            //TODO: return course if it exists or null
        }

        public bool AddStudentToCourse(String CourseName, Student student)
        {
            //TODO: add student to course
        }

        public bool AddStudentToCourse(String CourseName, String firstName, String lastName)
        {
            //TODO: add student to course
        }
        
        public bool RemoveStudentFromCourse(String CourseName, Student student)
        {
            //TODO: remove student from course
        }

        public bool RemoveStudentFromCourse(String CourseName, String fullName)
        {
            //TODO: remove student from course
        }
    }
}
