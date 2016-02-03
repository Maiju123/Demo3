using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_T1
{
    class Heater
    {   // properties
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public bool IsOn { get; set; } 

        //default constructor
        public Heater()
        {
            IsOn = true;
            Temperature = 100;
            Humidity = 75;
        }
        //methods    
        //PrintData

        public void PrintData()
    {
            Console.WriteLine("Heater data:");
            Console.WriteLine("Temperature is: {0}", Temperature);
            Console.WriteLine("Humidity is: {0}", Humidity);
            Console.WriteLine("Is Sauna On?: {0}", IsOn);
    }
        //returns object properties in a one string
        public override string ToString()
        {
            return "Temp= " + Temperature + " Humi= " + Humidity + " IsOn= " + IsOn; 
        }
    }
}
