using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program


          
    {
        /*
       // function with parameter-
        public void Show(string message)
        {
            Console.WriteLine("Hello " + message);
        }
        
        
        
        
        
        
        static void Main(string[] args)
        {
                /*
                //if-else example---
                int num = 11;  
                if (num % 2 == 0)  
                {  
                    Console.WriteLine("It is even number");  
                }  
                else  
                {  
                    Console.WriteLine("It is odd number");  
                } 


                */

        /*
        //if else example with input user

        Console.WriteLine("Enter a number to check grade:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0 || num > 100)
        {
            Console.WriteLine("wrong number");
        }
        else if (num >= 0 && num < 50)
        {
            Console.WriteLine("Fail");
        }
        else if (num >= 50 && num < 60)
        {
            Console.WriteLine("D Grade");
        }
        else if (num >= 60 && num < 70)
        {
            Console.WriteLine("C Grade");
        }
        else if (num >= 70 && num < 80)
        {
            Console.WriteLine("B Grade");
        }
        else if (num >= 80 && num < 90)
        {
            Console.WriteLine("A Grade");
        }
        else if (num >= 90 && num <= 100)
        {
            Console.WriteLine("A+ Grade");
        }


        */


        // for loop example-
        /*
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        */

        /*
                    // neted for loop-
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int j = 1; j <= 3; j++)
                        {
                            Console.WriteLine(i + " " + j);
                        }
                    }
        */

        /*
                    //infinite for loop-
                    for (; ; )
                    {
                        Console.WriteLine("Infinitive For Loop");
                    }


                    /*
                    // example of while loop-
                    int i = 1;
                    while (i <= 10)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                    */

        /*
                    //nested while loop ex-
                    int i = 1;
                    while (i <= 3)
                    {
                        int j = 1;
                        while (j <= 3)
                        {
                            Console.WriteLine(i + " " + j);
                            j++;
                        }
                        i++;
                    }
        */

        /*
                Program program = new Program();  
                program.Show("Mayur");   
   */



        /*
         //function call by value
         public void Show(int val)
         {
             val *= val;  
             Console.WriteLine("Value inside the show function " + val);

         }

         static void Main(string[] args)
         {
             int val = 50;
             Program program = new Program(); // Creating Object  
             Console.WriteLine("Value before calling the function " + val);
             program.Show(val); // Calling Function by passing value            
             Console.WriteLine("Value after calling the function " + val);
         }
         */

        /*
        // function call by reference
        public void Show(ref int val)
        {
            val *= val;  
            Console.WriteLine("Value inside the show function " + val);
           
        }
          
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(ref val);            
            Console.WriteLine("Value after calling the function " + val);
        }
        */


        /*
                // out parameter-
                public void Show(out int val)   
                {
                    int square = 5;
                    val = square;
                    val *= val;   
                }
                static void Main(string[] args)
                {
                    int val = 50;
                    Program program = new Program(); // Creating Object  
                    Console.WriteLine("Value before passing out variable " + val);
                    program.Show(out val); // Passing out argument  
                    Console.WriteLine("Value after recieving the out variable " + val);
                }
          */



        /// Array-
        /// 

        public static void Main(string[] args)
        {
            int[] arr = new int[5]; 
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;

             
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


    }
    
    }


    

