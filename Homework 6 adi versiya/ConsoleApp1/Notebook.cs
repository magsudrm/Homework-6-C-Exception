using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Notebook:Product
    {
        public Notebook(string name,int price,int ram):base(name,price)
        {
            Ram= ram;
        }
        public int Ram;
    }
}
