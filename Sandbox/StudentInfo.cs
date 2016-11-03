using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class StudentInfo
    {
        private Dictionary<int, Student> students;

        public StudentInfo()
        {
            students = new Dictionary<int, Student>();
        }

        // Return the number of students in the group of students
        public int GetStudentCount()
        {

            // The below must be changed
            return students.Count;
        }

        // Add a single student to the group of students
        public void AddStudent(int id, Student aStudent)
        {
            // Add code here
            students.Add(id, aStudent);
        }

        // Given an id, return the student with that id.
        // If no student exists with the given id, return null
        public Student GetStudent(int id)
        {
            
            // The below must be changed
            if (students.ContainsKey(id))
            {
                return students[id];
            }
            else
            {
                return null;
            }
           
        }

        // Given an id, return the score average for the student with that id.
        // If no student exists with the given id, return 0 (zero).
        public int GetAverageForStudent(int id)
        {
            // The below must be changed

            if (students.ContainsKey(id))
            {
                return students[id].GetScoreAverage();
            }
            else
            {
                return 0;
            }
        }

        // Calculate the total test score average for ALL students
        // in the group of students.
        // TIP: Use the method GetAllStudentId and a loop...
        public int GetTotalAverage()
        {
            // The below must be changed
            List<int> studlist = GetAllStudentId();
            int amnt = 0;

            foreach (int id in studlist)
            {
                amnt = amnt + GetAverageForStudent(id);
            }
            return (amnt / studlist.Count);
        }

        // Returns a list of all ids of the students in the group of students
        // (leave this method as it is)
        public List<int> GetAllStudentId()
        {
            // A little bit of black magic...
            return (new List<int>(students.Keys.ToArray()));
        }
    }
}
