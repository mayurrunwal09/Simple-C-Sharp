using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections
{
    internal class List
    {
        static void Main(string[] args)
        {

            var l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(4);
            l.Add(5);
            l.Add(3);
            Console.WriteLine("no of elements are: " + l.Count);
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            var location = new List<string>();
            location.Add("Mumbai");
            location.Add("Surat");

            Console.WriteLine("The location are: " + location.Count);

            foreach(string s in location)
                Console.WriteLine(s);
          
            
        }
    }
}
