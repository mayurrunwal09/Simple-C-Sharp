using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{

    public class index
    {
        public string[] name = new string[13];

        public string this[int indexer]
        {
            get => name[indexer];
            set => name[indexer] = value;
        }
    }

    //Indexer using Integer
    public class contno
    {
        public long[] no = new long[15];

        public long this[long indexer]
        {
            get => no[indexer];
            set => no[indexer] = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Indexer using String");
            index d = new index();
            
            d[1] = ("jan");
            d[2] = ("feb");
            d[4] = ("apr");
            d[5] = ("may");
            d[6] = ("jun");
            d[7] = ("jul");
            d[8] = ("Aug");
            d[9] = ("sep");
            d[10] = ("oct");
            d[11] = ("nov");
            d[12] = ("dec");

            for (int k = 1; k <= 12; k++)
            {
                Console.WriteLine(d[k]);
            }

            // Integer
            Console.WriteLine("This is Indexer using Integer");
            contno i = new contno();
            i[0] = 9923428304;
            i[1] = 1025486934;
            i[2] = 1034823698;

            i[4] = 1088454545;

            i[6] = 1074748556;
            i[7] = 1088785455;

            
            for (int j = 0; j <= 8; j++)
            {
                Console.WriteLine(i[j]);
            }

        }
    }
}
    
    

