using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[0];
            bool yesOrno = false;
            do
            {
                try
                {
                    Console.WriteLine("1 Yeni Notebook yarat");
                    Console.WriteLine("2 Notebooklar uzerinde axtaris et");
                    Console.WriteLine("0 Menudan cix");
                    var input2 = converted();
                    if (input2 != 0 && input2 != 1 && input2 != 2)
                    {
                        Console.WriteLine("Secim yanlisdir yeniden daxil edin");
                        yesOrno = true;
                    }
                    else if (input2 == 0)
                    {
                        Console.WriteLine("Proses bitdi");
                        return;
                    }
                    else if (input2 == 1)
                    {
                        try
                        {
                            Array.Resize(ref notebooks, notebooks.Length + 1);
                            for (int i = notebooks.Length; i == notebooks.Length; i++)
                            {
                                Console.Write($"{i} Notebook name daxil edin: ");
                                string name = Console.ReadLine();

                                Console.Write($"{i} Notebook price daxil edin: ");
                                int price = converted();

                                Console.Write($"{i} Notebook RAM daxil edin: ");
                                int ram = converted();
                                if(ram<=0 || ram > 128)
                                {
                                    Console.WriteLine("Ram verdiyiniz deyere uygun deyil");
                                    yesOrno=true;
                                }
                                notebooks[notebooks.Length - 1] = new Notebook(name, price, ram);
                            }
                            yesOrno = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Price ve RAM deyeri yalniz reqemlerden ibaret ola biler");
                            yesOrno = true;
                        }
                    }
                    if (input2 == 2)
                    {
                        Console.WriteLine("Axtarmaq istediyiniz inputu daxil edin");
                        string search = Console.ReadLine();
                        for (int i = 0; i < notebooks.Length; i++)
                        {
                            if (notebooks[i].Name.Contains(search))
                            {
                                Console.WriteLine($" Name: " + notebooks[i].Name + $" Price: " + notebooks[i].Price + $" RAM: " + notebooks[i].Ram);
                            }
                            yesOrno = true;
                        }
                    }
                }
                catch (FormatException exp1)
                {

                    Console.WriteLine("Yalniz reqem daxil ede bilersiniz"+exp1.Message);
                    yesOrno = true;
                }
               
            } while (yesOrno==true);

            static int converted()
            {
                string inputstr = Console.ReadLine();
                int input = Convert.ToInt32(inputstr);
                return input;
            }
        }
    }
}