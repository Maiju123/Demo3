using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_T1
{
    class Program
    {
        static void Main(string[] args)
        {   //Sauna heater create
            Heater heater = new Heater();
            heater.PrintData();

            Console.WriteLine("Temperature= " + heater.Temperature);

            Console.WriteLine(heater.ToString());
        }
    }
}
