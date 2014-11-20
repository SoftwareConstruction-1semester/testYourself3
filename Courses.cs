using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            foreach (Course course in _courses)
            {
                Console.WriteLine(course);
            }
        }

        public void PresentCoursesWithParticipants()
        {
            //TODO: print all courses includein name, description and participants
        }

        public bool AddCourse(String courseName, String courseDescription, int maxNumberOfParticipants)
        {
            Course c = new Course();
            c.Name = courseName;
            c.Description = courseDescription;
            c.MaxNumberOfParticipants = maxNumberOfParticipants;
            AddCourse(c);
            return true;
        }

        public bool AddCourse(Course course)
        {
            bool hasCourseAlready = _courses.Contains(course);
            
            if (!hasCourseAlready)
            {
                _courses.Add(course);
                return true;
            }
            return false;
        }

        public bool RemoveCourse(Course course)
        {
            if (_courses.Contains(course))
            {
                _courses.Remove(course);
                return true;
            }
            return false;
        }

        public bool RemoveCourse(String name)
        {
            Course toBeremoved = null;
            foreach (Course course in _courses)
            {
                if (course.Name.Equals(name))
                {
                    toBeremoved = course;
                }
            }
            if (toBeremoved != null)
            {
                _courses.Remove(toBeremoved);
                return true;
            }
            return false;
        }

        public Course GetCourse(String CourseName)
        {
            foreach (Course course in _courses)
            {
                if (course.Name.Equals(CourseName))
                {
                    return course;
                }
            }
            return null;
        }

        public bool AddStudentToCourse(String CourseName, Student student)
        {
            Course c = null;
            foreach (Course course in _courses)
            {
                if (course.Name.Equals(CourseName))
                {
                    c = course;
                }
            }
            if (c != null)
            {
                c.addStudent(student);
                return true;
            }
            return false;
        }

        public bool AddStudentToCourse(String CourseName, String firstName, String lastName)
        {
            Course c = null;
            foreach (Course course in _courses)
            {
                if (course.Name.Equals(CourseName))
                {
                    c = course;
                }
            }
            if (c != null)
            {
                c.addStudent(firstName, lastName);
                return true;
            }
            return false;
        }
        
        public bool RemoveStudentFromCourse(String CourseName, Student student)
        {
            Course c = null;
            foreach (Course course in _courses)
            {
                if (course.Name.Equals(CourseName))
                {
                    c = course;
                }
            }
            if (c != null)
            {
                c.removeStudent(student);
                return true;
            }
            return false;
        }

        public bool RemoveStudentFromCourse(String CourseName, String fullName)
        {
            Course c = null;
            foreach (Course course in _courses)
            {
                if (course.Name.Equals(CourseName))
                {
                    c = course;
                }
            }
            if (c != null)
            {
                c.removeStudent(fullName);
                return true;
            }
            return false;
        }
    }
}
