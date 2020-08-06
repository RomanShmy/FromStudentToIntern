using System.Linq;
using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        private string name;
        public List<Student> Students { get; set; }
        public University(string name)
        {
            this.name = name;
            this.Students = new List<Student>();
        }

        public double getAvg()
        {
            return Sum(Students) / Students.Count;
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
            Students.Add(student);
        }
    }
}
