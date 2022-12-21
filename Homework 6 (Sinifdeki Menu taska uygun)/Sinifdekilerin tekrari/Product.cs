using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekilerin_tekrari
{
    internal class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public string Name;
        public int Price;
    }
}
