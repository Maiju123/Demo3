using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_Kotitehtava4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vechile vechile = new Vechile();
            vechile.PrintData();

            Console.WriteLine("Vechile= " + vechile.Name);

            Console.WriteLine(vechile.ToString());
        }
    }
}
