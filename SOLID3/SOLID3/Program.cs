using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID3
{
   public abstract class stud
    {
        public abstract void display();
    }
        
   public class student : stud
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        

        public void studinfo()
        {
            this.id = 1;
            this.name = "ABC";
            this.gender = "male";
        }
        public void deletestud()
        {
            this.id = 1;
           
        }
        public void updatestud()
        {
            this.id = 101;
            
        }

        public College c = new College();
        public void save()
        {
            c.studinfo(this);
            c.deletestud(this);
            c.updatestud(this);
            

        }
        public override void display()
        {
            Console.WriteLine("the information is saved");
        }
       
    }
    public class College : stud
    {

        public void studinfo(student s)
        {
            Console.WriteLine($"The id of student is: {s.id} ");
            Console.WriteLine($"The name of the student is: {s.name}");
            Console.WriteLine($"syudent gender- {s.gender}");
        }
        public void deletestud(student s)
        {
            Console.WriteLine($"the element is deleted id: {s.id}");
        }
        public void updatestud(student s)
        {
            Console.WriteLine($"student ID is updated: {s.id }");
        }
        public override  void display()
        {
            Console.WriteLine("the solid principle");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.studinfo();
            s.save();
            s.display();
        }
    }
}
