using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace Sinifdekilerin_tekrari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[0];
            do
            {
                CW("1 Yeni Notebook yarat");
                CW("2 Notebooklar uzerinde axtaris et");
                CW("0 Menudan cix");
                string opt = Console.ReadLine();
                if (opt == "1")
                {
                    notebooks = newArray(ref notebooks);
                }
                else if (opt == "2")
                {
                    searcher(notebooks);
                }
                else if (opt == "0")
                {
                    CW("Proses bitdi");
                    return;
                }
            } while (true);
        }
        static Notebook[] newArray(ref Notebook[] arr)
        {
            try
            {
                Console.Write("Notebook name daxil edin: ");
                string name = Console.ReadLine();
                name = name.ToLower();

                Console.Write("Notebook price daxil edin: ");
                int price = converted();
                if (price < 0)
                {
                    CW("Price deyeri menfi ola bilmez");
                }

                Console.Write("Notebook RAM daxil edin: ");
                int ram = converted();
                if (ram > 128 || ram < 0)
                {
                    CW("Ram deyeri duzgun daxil edilmeyib");
                }
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = new Notebook(name, price, ram);
            }
            catch (FormatException exp1)
            {
                CW("Price ve Ram deyeri yalniz eded ola biler: " + exp1.Message);
            }
            catch(OverflowException)
            {
                CW("Daxil edilen deyer Int deyerini kece bilmez");
            }
            return arr;
        }
        static void searcher(Notebook[] arr)
        {
            CW("Axtarmaq istediyiniz inputu daxil edin");
            string search = Console.ReadLine();
            search=search.ToLower();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Name.Contains(search))
                {
                    CW($"Name: {arr[i].Name} - Price: {arr[i].Price}- RAM: {arr[i].Ram}");
                }
            }
        }
        static int converted()
        {
            string inputstr = Console.ReadLine();
            int input = Convert.ToInt32(inputstr);
            return input;
        }
        static void CW(string input)
        {
            Console.WriteLine(input);
        }
    }
}

