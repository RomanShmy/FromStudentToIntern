using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university1 = new University("CH.U.I.");
            university1.AddStudent(new Student("Andrew Kostenko", new Knowledge(35)));
            university1.AddStudent(new Student("Julia Veselkina", new Knowledge(53)));
            university1.AddStudent(new Student("Maria Perechrest", new Knowledge(65)));

            University university2 = new University("CH.U.I.");
            university2.AddStudent(new Student("Stas Pashenko", new Knowledge(100)));
            university2.AddStudent(new Student("Solovey Adrii", new Knowledge(54)));
            university2.AddStudent(new Student("Shmyhol Roman", new Knowledge(23)));

            Internship internship = new Internship("Interlink");
            internship.AddStudent(university1);
            internship.AddStudent(university2);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
