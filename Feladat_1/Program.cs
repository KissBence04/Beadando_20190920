using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_1
{
    class Program
    {
    public static List<int> lista;

        static void Main(string[] args)
        {
            lista = new List<int>();
            int szam;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kérek adjon meg egy számot!");
                szam = Convert.ToInt32(Console.ReadLine());
                lista.Add(szam);
            }
            int max= lista.Max();
            Console.WriteLine("A legnagyobb elem a listában."+max);
            Console.ReadKey();

        }
    }
}
