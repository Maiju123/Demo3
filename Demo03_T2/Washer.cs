using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_T2
{
    class Washer
    {   //properties, ominaisuudet
        public string Brand { get; set; }
        public string Model { get; set; }
        public int SpinSpeed { get; set; }
        public int LaundryAmount { get; set; }
         
        //methods

        public void PrintData()
            {
            Console.WriteLine("WashingMachine's Brand is: {0}", Brand);
            Console.WriteLine("WashingMachine's Model is: {0}", Model);
            Console.WriteLine("WashingMachine's Spin speed is: {0}", SpinSpeed);
            Console.WriteLine("WashingMachine's Laundry amount is: {0}", LaundryAmount);
            }

    }
}
