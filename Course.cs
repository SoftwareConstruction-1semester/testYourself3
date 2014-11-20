using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TestYourelf3CourseList
{
    internal class Course
    {
        private List<Student> _participants = new List<Student>();

        public String Name { get; set; }
        public String Description { get; set; }
        public int MaxNumberOfParticipants { get; set; }
        public int NumberOfParticipants { get; set; }

        /// <summary>
        /// Add student to course
        /// </summary>
        /// <param name="student">Student object</param>
        /// <returns>true if student is added</returns>
        public bool addStudent(Student student)
        {
            //TODO: add student to course of max number is not reached. increment number of participants
        }

        public bool addStudent(String firstName, String lastName)
        {
            //TODO: add student to course of max number is not reached. increment number of participants
        }

        /// <summary>
        /// Removes student form course
        /// </summary>
        /// <param name="student">Student object</param>
        /// <returns>true if student is removed</returns>
        public bool removeStudent(Student student)
        {
            //TODO: remove student from course. return true if student is removed.
        }

        /// <summary>
        /// Removes student form course
        /// </summary>
        /// <param name="student">Student object</param>
        /// <returns>true if student is removed</returns>
        public bool removeStudent(String fullName)
        {
            //TODO: remove student from course. return true if student is removed.
        }
        
        /// <summary>
        /// Check if student is enrolled
        /// </summary>
        /// <param name="student">Student object</param>
        /// <returns>true if student is enrolled</returns>
        public bool isEnrolled(Student student)
        {
            //TODO: Return true if student is enrolled
        }

        /// <summary>
        /// return whether or not this course has a valid name and description
        /// </summary>
        /// <returns></returns>
        public bool isValid()
        {
            //TODO: return true if name is used and description is between 20 and 100 characters
        }

        public override string ToString()
        {
            //TODO: return all information about course
        }
    }
}