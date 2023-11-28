using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @implicit
{
    public class Program
    {
        static void Main(string[] args)
        {
			var i = 20;
			Console.WriteLine("Type of i is ", i.GetType());

			var name = "i am mayur";
			Console.WriteLine("Type of str is ", name.GetType());

			var db = 100.50d;
			Console.WriteLine("Type of dbl is ", db.GetType());

			var check = true;
			Console.WriteLine("Type of isValid is ", check.GetType());

			var giv = new[] { 1, 10, 20, 30 };
			Console.WriteLine("Type of arr is ", giv.GetType());

			
		}
    }
}
									//Type of i is
							       	//		Type of str is
									//	Type of dbl is
									//	Type of isValid is
									//	Type of arr is
									///	Press any key to continue . . .