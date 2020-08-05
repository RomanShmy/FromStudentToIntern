namespace InternshipTest.Person
{
    public class Student
    {
        public string Name { get; set; } 
        public Knowledge Knowledge { get; set; }
        public Student(string name, Knowledge knowledge)
        {
            this.Name = name;
            this.Knowledge = knowledge;
        }
    }
}