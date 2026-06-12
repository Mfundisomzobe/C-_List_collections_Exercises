using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_and_Filtering
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get;set; }
        public string Category { get; set; } = null!;

        public Product(int id, string name, decimal price, string category)
        {
            Id = id;
            Name = name;
            Price= price;
            Category = category;
            
        }

        public override string ToString()
        {
            return $" Name: {Name}, Price: {Price}, Category: {Category}";
        }
    }
}
