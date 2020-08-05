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
            var goodStudentsFromUniversity = university.GetGoodStudents();
            students.AddRange(goodStudentsFromUniversity);
        }

        public string GetStudents()
        {
            foreach(var student in students)
            {
                listOfInterns.Append(student.Name + "\n");
            }
            return listOfInterns.ToString();
        }
    }
}
