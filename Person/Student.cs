namespace InternshipTest.Person
{
    public class Student
    {
        public string Name { get; private set; } 
        public Knowledge Knowledge { get; private set; }
        public Student(string name, Knowledge knowledge)
        {
            this.Name = name;
            this.Knowledge = knowledge;
        }
    }
}