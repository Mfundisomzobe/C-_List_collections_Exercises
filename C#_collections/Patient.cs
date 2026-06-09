using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__collections
{
    internal class Patient
    {
        // You need this:
        
        
            public int Id { get; set; }
            public string Name { get; set; }


            public Patient(int id, string name)
            {
                Id = id;
                Name = name;
            }
           
    
    public override string ToString()
        {
            return $"Patient[ID: {Id}, Name: {Name}]";
        }

    }
}
