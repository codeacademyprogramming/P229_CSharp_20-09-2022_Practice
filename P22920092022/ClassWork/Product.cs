using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double TotalIncome;

        public Product(string name)
        {
            Name = name;
        }

        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
            }
            else
            {
                Console.WriteLine("Satis Bas Vere Bilmez");
            }
        }
    }
}
