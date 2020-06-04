using System;

namespace Beverages.Models
{
    public class Water : Drink
    {
        public Water (double volume, string color, int temp, bool isC) : base (volume, color, temp, isC)
        { }

        public override void Imbibe()
        {
            if(Temperature >= 50) 
            {
                Console.WriteLine("sip sip...");
            }
            else
            {
                Console.WriteLine("glug glug...");
            }
        }
    }
}