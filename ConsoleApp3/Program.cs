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
            ConsoleKeyInfo key = Console.ReadKey();
            DateTime dateTime = DateTime.Today;
            List<Zametka> list = new List<Zametka>();
            Console.SetCursorPosition(0, position);
            Menu();
            while (true)
            {
                Arrow();
                Data();
                Console.Clear();
                Console.WriteLine(dateTime);
                foreach (Zametka zam in list)
                {
                    if (zam.End == dateTime)
                    {
                        Console.WriteLine(zam.Name);
                    }
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    for (int i = 0; i < list.Count; i++)
                        Console.WriteLine(list[i].Description);
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-*");
            }
        }
        static void Menu()
        {
            DateTime dateTime = DateTime.Today;
            Zametka zametka1 = new Zametka();
            zametka1.GeneralName = "  Заметка";
            zametka1.Name = "  Посидеть на парах";
            zametka1.Description = "  Всего лишь 2 ура";
            zametka1.End = dateTime;

            Zametka zametka2 = new Zametka();
            zametka2.GeneralName = "  Заметка";
            zametka2.Name = "  Посидеть на парах";
            zametka2.Description = "  Целых 5";
            zametka2.End = dateTime.AddDays(1);

            Zametka zametka3 = new Zametka();
            zametka3.GeneralName = "  Заметка";
            zametka3.Name = "  Посидеть на парах";
            zametka3.Description = "  После 4 поехать домой и осознать, что еще в субботу ехать";
            zametka3.End = dateTime.AddDays(2);

            Zametka zametka4 = new Zametka();
            zametka4.GeneralName = "  Заметка";
            zametka4.Name = "  Посидеть на парах";
            zametka4.Description = "  После 4 радостным поехать домой";
            zametka4.End = dateTime.AddDays(3);

            Zametka zametka5 = new Zametka();
            zametka5.GeneralName = "  Заметка";
            zametka5.Name = "  Позвать Дениса в доту и забыть";
            zametka5.Description = "  опять";
            zametka5.End = dateTime.AddDays(4);

            List<Zametka> list = new List<Zametka>();
            return;
        }
            static void Arrow()
        {
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                position++;
            }
        }
        static void Data()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            DateTime dateTime = DateTime.Today;
            if (key.Key == ConsoleKey.LeftArrow)
            {
                dateTime = dateTime.AddDays(-1);
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                dateTime = dateTime.AddDays(1);
            }

        }
    }

}