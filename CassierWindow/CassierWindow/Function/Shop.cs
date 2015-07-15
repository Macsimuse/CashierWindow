using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace Silpo
{
    public class Shoping : IEnumerable
    {
        DiscountKeyActivate.Key keyInst = new DiscountKeyActivate.Key();
        

        AvailebleElements Availeblinst = new AvailebleElements();
        List<DataElements> CustomerShoping = new List<DataElements>();
        int _id = 0;
       
        public int Count { get { return CustomerShoping.Count; } }

        public void CleanBill()
        {
            CustomerShoping.Clear();
        }

        public void AddToBill(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id)) throw new NullReferenceException("Please enter a value");
            else if (Int32.TryParse(Id, out _id))
            {
                if (Availeblinst.GetVallueBool(_id))
                {
                    CustomerShoping.Add((DataElements)Availeblinst.GetVallueObj(_id));
                }
            }

            else
            {
                throw new NullReferenceException("Please enter correct ID");
            }
        }

        // Total Sum of Purchasing without Discount
        public double CalculateSum()
        {
            double sum = 0;
            for (int index = 0; index < CustomerShoping.Count; index++)
            {
                sum += CustomerShoping[index].Price;
            }
            return sum;
        }

        // Total Sum include Discount
        public double CalculateDiscount(string discount)
        {
            int[] temp = keyInst.DiscountArray;
            int _checkDiscount = 0;

            if (string.IsNullOrWhiteSpace(discount)) return 0;
            if (Int32.TryParse(discount, out _checkDiscount))
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == _checkDiscount)
                    {
                        double _sum = CalculateSum();
                        return _sum * keyInst.DiscauntPercent;
                    }
                }
            }
            else throw new NullReferenceException("Discount number invalid");
            return 0;
        }


        public IEnumerator GetEnumerator()
        {
            foreach (DataElements enumer in CustomerShoping)
            { 
                yield return enumer.Name + "  " + enumer.Price; 
            }
        }
    }
}
