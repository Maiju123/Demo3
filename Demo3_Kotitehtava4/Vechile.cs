using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_Kotitehtava4
{
    class Vechile
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // methods

        // vechile actions
        public Vechile()
        {
            Speed = 100;
            Tyres = 4;
        }
        // prints properties
        public void PrintData()
        {
            Console.WriteLine("Vechile Name is: {0}", Name);
            Console.WriteLine("Vechile can go: {0} km/h", Speed);
            Console.WriteLine("Vechile has {0} tyres", Tyres);
        }
        //returns object properties in a one string
        public override string ToString()
        {
            return "Name=  " + Name + " Speed= " + Speed + " Tyres= " + Tyres;
        }
    }
}
