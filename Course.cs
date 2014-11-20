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
            if (MaxNumberOfParticipants > NumberOfParticipants)
            {
                if (!_participants.Contains(student))
                {
                    _participants.Add(student);
                    NumberOfParticipants++;
                    return true;
                }
            }
            return false;
        }

        public bool addStudent(String firstName, String lastName)
        {
            if (MaxNumberOfParticipants > NumberOfParticipants)
            {
                bool hasStudent = false;
                foreach (Student participant in _participants)
                {
                    if (participant.FirstName = firstName && participant.LastName = lastName)
                    {
                        hasStudent = true;
                    }
                }
                if (hasStudent = false)
                {
                    Student s= new Student();
                    s.FirstName = firstName;
                    s.LastName = lastName;
                    _participants.Add(s);
                    NumberOfParticipants++;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Removes student form course
        /// </summary>
        /// <param name="student">Student object</param>
        /// <returns>true if student is removed</returns>
        public bool removeStudent(Student student)
        {
            if (_participants.Contains(student))
            {
                _participants.Remove(student);
                NumberOfParticipants--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes student form course
        /// </summary>
        /// <param name="student">Student object</param>
        /// <returns>true if student is removed</returns>
        public bool removeStudent(String fullName)
        {
            Student toBeRemoved = null;
            foreach (Student participant in _participants)
            {
                if ((participant.FirstName + " " + participant.LastName).Equals(fullName))
                {
                    hasStudent = true;
                }
            }
            if (toBeRemoved != null)
            {
                _participants.Remove(toBeRemoved);
                NumberOfParticipants--;
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Check if student is enrolled
        /// </summary>
        /// <param name="student">Student object</param>
        /// <returns>true if student is enrolled</returns>
        public bool isEnrolled(Student student)
        {
            return _participants.Contains(student);
        }

        /// <summary>
        /// return whether or not this course has a valid name and description
        /// </summary>
        /// <returns></returns>
        public bool isValid()
        {
            return (Name != "" && Description.Length > 20 && Description < 100);
        }

        public override string ToString()
        {
            return Name + "\t" + Description;
        }
    }
}