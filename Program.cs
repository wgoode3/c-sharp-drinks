using System;
using System.Collections.Generic;
using Beverages.Models;

namespace Beverages
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink d1 = new Water(350.0, "transparent", 4, false);
            d1.Imbibe();
            d1.Temperature += 100;
            d1.Imbibe();
            Coffee c1 = new Coffee(150, "black", 85, 100, "arabica");
            Drink d2 = (Drink) c1; 
            d2.Imbibe();
            // Water w1 = (Water) d2;
            List<Drink> Refrigerator = new List<Drink>();
            Refrigerator.Add(d1);
            Refrigerator.Add(d2);
            Refrigerator.Add(c1);
            List<ICaffeinated> WillsCoffeeShop = new List<ICaffeinated>();
            WillsCoffeeShop.Add(c1);
            WillsCoffeeShop.Add((ICaffeinated) d2);
            WillsCoffeeShop.Add((ICaffeinated) d1);
        }
    }
}
