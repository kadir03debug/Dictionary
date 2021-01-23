using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            mydictionary<string, int> ogrenci = new mydictionary<string, int>();
            ogrenci.Add(1, "kadir");
            ogrenci.Add(2, "eda");
            ogrenci.Add(3, "özge");
            // 1. Eklenen yer
            Console.WriteLine(ogrenci.Count);
        }
    }
}