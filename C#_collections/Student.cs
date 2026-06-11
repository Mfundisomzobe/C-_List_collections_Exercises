using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__collections
{
    internal class Student
    {
        // You need this:
        
        
            public int Id { get; set; }
            public string Name { get; set; }
            public int Grade { get; set; }


            public Student(int id, string name, int grade)
            {
                Id = id;
                Name = name;
                Grade = grade;
            }
           
    
    public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Grade: {Grade} ";
        }

    }
}
