using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface iemp
    {
        string Name { get; set; }
        int Id { get; set; }
        void Display();
    }
    class info : iemp
    {
        public string name; 
        public int id; 

        public info(string n, int i) 
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
            Console.WriteLine("The name is: " + name);
            Console.WriteLine("id is: " + id);
        }
    }
     class Department : iemp
    {
        private string name;
        private int id; 

        public Department(string n, int i) 
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
            Console.WriteLine("Department name: " + name);
            Console.WriteLine("Department id: " + id);
        }
    }
         class Program
        {
             static void Main(string[] args)
             {
                  info i = new info("Mayur", 01); // class properties called by creating object.
                  i.Display(); 

                  Department d = new Department("Computer", 133 ); 
                  d.Display(); 
             }

         }
}
