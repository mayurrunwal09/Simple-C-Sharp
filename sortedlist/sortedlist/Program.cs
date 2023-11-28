using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    internal class Sorted_list
    {
        static void Main(string[] args)
        {
            SortedList<int, string> num = new SortedList<int, string>();
            num.Add(2,"v");
            num.Add(4, "b");
            num.Add(1, "w");
            num.Add(3, "m");
          ;
            Console.WriteLine(num);
            foreach (var n1 in num)
               
                Console.WriteLine("key: {0}, value: {1}", n1.Key, n1.Value);
            Console.WriteLine(num.Count); /// count the array list

            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"Maharashtra", "Mumbai"},
                                        {"Gujrath","Surat"},
                                        {"UP", "Luckhnow"},
                                        {"Telangana", "Hyderabad"}
                                    };
            Console.WriteLine("---Cities---");
            foreach (var kvp in cities)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);




        }
    }
}
