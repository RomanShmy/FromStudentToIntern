using System.Linq;
using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        private string name;
        private List<Student> students;
        public University(string name)
        {
            this.name = name;
            this.students = new List<Student>();
        }

        public List<Student> GetGoodStudents()
        {
            List<Student> goodStudent = new List<Student>();
            double avgMark = getAvg();

            foreach(var student in students)
            {
                if(student.Knowledge.Level > avgMark)
                {
                    goodStudent.Add(student);
                }
            }

            return goodStudent;
            
        }

        public double getAvg()
        {
            return Sum(students) / students.Count;
        }

        public int Sum(List<Student> students, int n = 0)
        {
            if (n == students.Count - 1)
            {
                return students.ElementAt(n).Knowledge.Level;
            }

            return students.ElementAt(n).Knowledge.Level + Sum(students, n + 1);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
