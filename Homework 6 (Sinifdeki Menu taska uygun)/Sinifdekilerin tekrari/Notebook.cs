using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifdekilerin_tekrari
{
    internal class Notebook:Product
    {
        public Notebook(string name, int price, int ram) : base(name, price)
        {
            Ram = ram;
        }
        public int Ram;
        public string getInfo()
        {
            return $"Name: {Name} - Price: {Price}- RAM: {Ram}";
        }
    }
}
