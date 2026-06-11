using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Policy;


namespace C__collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            // Exercise 1.1: Add 5 students manually
            // TODO: Add students with different names and grades
            students.AddRange(new Student[] {new Student(1,"Umar",78),
                                             new Student(2,"James",34),
                                             new Student(3,"Alex",56),
                                             new Student(4,"John",92),
                                             new Student(5,"Sipho",20)});

            // Exercise 1.2: Display all student
            // TODO: Print all students using a foreach loop
            Console.WriteLine("All Students");
            Console.WriteLine("-------------");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // Exercise 1.3: Remove a student by ID
            // TODO: Remove the student with ID = 3
            Console.WriteLine();
            int stu3 = 3;
            Student studentremove = students.Find(p => p.Id == stu3);
            if(studentremove != null) 
            {
                students.Remove(studentremove);
                Console.WriteLine( $"student with Id {stu3} has been removed");
            }

            // Exercise 1.4: Remove a student by name
            // TODO: Remove the student named "John" (if exists)
            Console.WriteLine();
            string name = "John";
             Student StuName= students.Find(p => p.Name == name);
            if(StuName != null)
            {
                students.Remove(StuName);
                Console.WriteLine($"student with name {name} has been removed");

            }

            // Exercise 1.5: Display the count of students
            // TODO: Print "Total students: X"
            Console.WriteLine();
            Console.WriteLine("Total Number of students");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Total Number of students are {students.Count}");



            Console.ReadLine();
        }
    }
}
