using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Silpo
{
   public class DataElements
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return String.Format("Name of Item: {0} ID: {1} Price: {2:C}",Name,ID,Price);
        }
       
    }

   public class AvailebleElements
    {
       #region ShopItems
       SortedDictionary<int, DataElements> sortlist1 = new SortedDictionary<int, DataElements>()
       {
          { 1, new DataElements() { Name = "Apple", ID = 1, Price = 4 } },
          {3,new DataElements(){Name = "Cheese", ID = 3, Price = 11.22}},
          {2,new DataElements(){ Name = "Pampers", ID = 2, Price = 78.65}},
          {4,new DataElements(){ Name = "Fish", ID = 4, Price = 32.11 }},
          {5,new DataElements(){ Name = "Cucumber", ID = 5, Price = 12.05 }},
          {6,new DataElements(){ Name = "Olive", ID = 6, Price = 34 }},
          {7,new DataElements(){ Name = "Peperoni", ID = 7, Price = 19.78 }},
          {8,new DataElements(){ Name = "Meat", ID = 8, Price = 80.61 }},
          {9,new DataElements(){ Name = "Checken", ID = 9, Price = 42.11 }},
          {10,new DataElements(){ Name = "Chocolate", ID = 10, Price = 22.88 }},
          {11,new DataElements(){ Name = "Water", ID = 11, Price = 12.18 }},
          {12,new DataElements(){ Name = "Nuts", ID = 12, Price = 7.60 }},
          {16,new DataElements(){ Name = "Tea", ID = 16, Price = 17.01 }},
          {17,new DataElements(){ Name = "Honey", ID = 17, Price = 54.81 }}
       };
       #endregion
       public object GetVallueObj(int id)
       {
           foreach (int key in sortlist1.Keys)
            {
                if (key == id)
                 return sortlist1[key]; 
            }
            return null;
        }

        public bool GetVallueBool(int id)
        {
            foreach (int key in sortlist1.Keys)
            {
                if (key == id)
                    return true;
            }
            return false;
        }
    }  
}
