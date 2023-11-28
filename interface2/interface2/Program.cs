using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{


    interface IName
    {
        string Name { get; set; } 
    }

    interface IId
    {
        int Id { get; set; } 
    }

   
    class emp : IName, IId
    {
        private string name; 
        private int id; 

        public emp(string n, int i) 
        {
            name = n;
            id = i;
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public void Display() 
        {
            Console.WriteLine("Emp name: " + name);
            Console.WriteLine("Emp id: " + id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp("Mayur", 123); 
            e.Display(); 
        }
    }
}