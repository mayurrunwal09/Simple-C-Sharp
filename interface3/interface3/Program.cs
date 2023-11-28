using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface3
{
    interface iget
    {
        void add();
        void expo();
        void sub(int i,int j);




    }
    public class show : iget
    {
        public void add()
        {
            int a = 2;
            int b = 4;
            Console.WriteLine("The addition is: "+(a + b));
        }
        
        public void sub(int i,int j)
        {
            
            Console.WriteLine("The subtraction is: "+(i-j));
            
        }
        public void expo()
        {
            int res = 1;
            Console.WriteLine("enter the value: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the exponential factor:");
            int e = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < e; i++)
            {
                res *= num;
               
            }
            Console.WriteLine("the exponential value is " + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            show s = new show();
            s.add();
            s.sub(10,5);
            s.expo();

            iget g = new show(); /// creating a object of interface class
            g.add();

        }
    }
}
