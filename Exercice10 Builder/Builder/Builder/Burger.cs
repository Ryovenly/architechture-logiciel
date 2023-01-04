using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Burger
    {
        private string _burgerType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();
        // Constructor
        public Burger(string vehicleType)
        {
            this._burgerType = vehicleType;
        }
        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("BurgerVehicle Type: {0}", _burgerType);
            Console.WriteLine(" Bread : {0}", _parts["bread"]);
            Console.WriteLine(" Meat : {0}", _parts["meat"]);
            Console.WriteLine(" Vegetables: {0}", _parts["vegetables"]);
            Console.WriteLine(" Sauce : {0}", _parts["sauce"]);
            Console.WriteLine(" Cheese : {0}", _parts["cheese"]);

        }
    }
}
