using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            int position = 1;
            int poslist = 400;
            DateTime dateTime = DateTime.Today;
            List<Zametka> list = new List<Zametka>();
            Console.SetCursorPosition(0, position);
            Menu();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(dateTime);
                foreach (Zametka zam in list)
                {
                    if (zam.End == dateTime)
                    {
                        Console.WriteLine(zam.GeneralName);
                    }
                }
                Console.SetCursorPosition(0, 2);
                Console.WriteLine(list[poslist].Name);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                Arrow(key);
            }
            void Menu()
            {
                DateTime dateTime = DateTime.Today;
                Zametka zametka1 = new Zametka();
                zametka1.GeneralName = "  Заметка1";
                zametka1.Name = "  Посидеть на парах";
                zametka1.Description = "  Всего лишь 2 ура";
                zametka1.End = dateTime;

                Zametka zametka2 = new Zametka();
                zametka2.GeneralName = "  Заметка2";
                zametka2.Name = "  Посидеть на парах";
                zametka2.Description = "  Целых 5";
                zametka2.End = dateTime.AddDays(1);

                Zametka zametka3 = new Zametka();
                zametka3.GeneralName = "  Заметка3";
                zametka3.Name = "  Посидеть на парах";
                zametka3.Description = "  После 4 поехать домой и осознать, что еще в субботу ехать";
                zametka3.End = dateTime.AddDays(2);

                Zametka zametka4 = new Zametka();
                zametka4.GeneralName = "  Заметка4";
                zametka4.Name = "  Посидеть на парах";
                zametka4.Description = "  После 4 радостным поехать домой";
                zametka4.End = dateTime.AddDays(3);

                Zametka zametka5 = new Zametka();
                zametka5.GeneralName = "  Заметка5";
                zametka5.Name = "  Позвать Дениса в доту и забыть";
                zametka5.Description = "  опять";
                zametka5.End = dateTime.AddDays(4);

                for (int i = 0; i < 1000; i++) {
                    list.Add(new Zametka());
                }
                list[400] = (zametka1);
                list[401] = (zametka2);
                list[402] = (zametka3);
                list[403] = (zametka4);
                list[404] = (zametka5);
            }

            void Arrow(ConsoleKeyInfo key)
            {
                if (key.Key == ConsoleKey.UpArrow && position >= 2)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow && position <= 5)
                {
                    position++;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    dateTime = dateTime.AddDays(-1);
                    poslist--;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    dateTime = dateTime.AddDays(1);
                    poslist++;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    Console.WriteLine(list[poslist].Description);
                    Console.ReadLine();
                }
            }
        }
    }

}
