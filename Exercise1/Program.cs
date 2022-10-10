using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private int[] aan = new int[39];

        private int n;

        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya angka:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 39)
                    break;
                else
                    Console.WriteLine("\nArray hanya dapat menyimpan 20 angka.\n");
            }
            Console.WriteLine(" Masukan elemen array ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                aan[i] = Int32.Parse(s1);
            }
        }
        public void sort()
        {
            
            for (int AM = 0; AM < n - 2; AM++) 
            {
                int temp;
                temp = aan[AM];
                for (int k = AM + 1; k < n - 1; k++)
                {
                    if (aan[k] < temp)
                   {
                        temp = aan[k];
                    }  
                }
                temp = aan[AM];
            }
        }
        public void display()
        {
            Console.WriteLine(" Element array yang telah tersusun ");
            for (int AM = 0; AM < n; AM++)
            {
                Console.WriteLine(aan[AM]);
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Program coba = new Program();
            coba.read();
            coba.sort();
            coba.display();
            Console.Read();
        }
    }
}
