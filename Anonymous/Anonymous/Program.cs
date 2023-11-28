 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
	internal class Program
	{

       static void Main(string[] args)
		{
			// Anonymous variables
			var stu = new { Roll_No = 1, name = "mayur", mobile_no = 8989898989, addr = "yeola", branch = "computer" };
			Console.WriteLine(stu.GetType().ToString());



		}
	}
}
				//<>f__AnonymousType0`5[System.Int32,System.String,System.Int64,System.String,System.String]
		     	//	Press any key to continue . . .
 