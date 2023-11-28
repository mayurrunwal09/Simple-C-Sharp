using System;using System.Collections.Generic;using System.Linq;using System.Reflection;using System.Text;using System.Threading.Tasks;namespace CUSTOMATTRIBUTE{    [AttributeUsage(       AttributeTargets.Class |       AttributeTargets.Constructor |       AttributeTargets.Field |       AttributeTargets.Method |       AttributeTargets.Property,       AllowMultiple = true)]

    class MyAttribute : Attribute    {        private string city;        private string Adress;        public MyAttribute(string c, string A)        {            city = c;            Adress = A;        }        public static void AttributeDisplay(Type classType)        {            Console.WriteLine("Methods of class {0}", classType.Name);            MethodInfo[] methods = classType.GetMethods();

            for (int i = 0; i < methods.GetLength(0); i++)
            {

                object[] attributesArray = methods[i].GetCustomAttributes(true);

                foreach (Attribute item in attributesArray)
                {                    if (item is MyAttribute)                    {                        MyAttribute attributeObject = (MyAttribute)item;                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,                         attributeObject.city, attributeObject.Adress);                    }                }            }        }    }    class Teacher    {        int id;        string name;        public Teacher(int i, string n)        {            id = i;            name = n;        }        [MyAttribute("Accessor", "Gives value of Teacher Id")]        public int getId()        {            return id;        }        [MyAttribute("Accessor", "Gives value of Teacher Name")]        public string getName()        {            return name;        }    }}

