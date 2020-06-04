using System;

namespace Beverages.Models
{
    public class Coffee : Drink, ICaffeinated
    {
        public int CaffeinAmount { get; set; }
        public string BeanType { get; set; }
        public Coffee (double volume, string color, int temp, int cAmt, string bean) : base (volume, color, temp, false)
        {
            if (cAmt <= 0)
            {
                throw new Exception ("This Coffee must have caffein in it!");
            }
            BeanType = bean;
            CaffeinAmount = cAmt;
        }

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