using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountKeyActivate
{
    public class Key
    {
        // Key for Discount
        int[] discount = new int[4]{12345, 54321, 09876,54790};
        const double discauntPercent = 0.2;

        public int DiscountCount { get { return discount.Length; } }
        public int[] DiscountArray { get { return discount; } }
        public double DiscauntPercent { get { return discauntPercent; } }
        private void AddKey(int newKey)
        {
            int[] temp = new int[discount.Length + 1];
            for (int index = 0; index < discount.Length; index++)
            { discount[index] = temp[index]; }
            temp[discount.Length] = newKey;
            discount = temp;
        }

        private void Clear()
        { 
            discount = new int[0];
        }

   }
}
