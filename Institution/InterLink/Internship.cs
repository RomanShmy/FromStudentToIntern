using System.Collections.Generic;
using System.Text;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string name;
        private StringBuilder listOfInterns;
        private List<Student> students;
        public Internship(string name)
        {
            this.name = name;   
            listOfInterns = new StringBuilder();
            students = new List<Student>();  
        }

        public void AddStudent(University university)
        {
            var avg = university.getAvg();
            foreach(var student in university.Students)
            {
                if (student.Knowledge.Level > avg)
                {
                    students.Add(student);
                    listOfInterns.Append(student.Name + "\n");
                }
            }

        }

        public string GetStudents()
        {
            return listOfInterns.ToString();
        }
    }
}
