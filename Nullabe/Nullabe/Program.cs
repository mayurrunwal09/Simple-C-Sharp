using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabe
{
    internal class Program
    {
        public Nullable<int> i = null; //1st 

        public int? a = null; //2nd 
        static void Main(string[] args)
        {
            Program p = new Program();
            //1st way
            if (p.i == null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine(p.i);
            }

            //2nd way
            if (p.a == null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine(p.i);
            }
        }
    }
}                                    //NULL
                                 //       NULL
                                 //   Press any key to continue . .
                              
