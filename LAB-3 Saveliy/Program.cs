/*
 Вариант 7
Product: Наименование, Производитель, Цена, 
Срок хранения, Количество. Создать массив объектов. Вывести:
•	список товаров для заданного наименования;
•	список товаров для заданного наименования, 
    цена которых не превышает указанной;
•	список товаров, срок хранения которых больше заданного.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_Saveliy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product();
            pr1.Имя = "паста арахисовая";
            string i1 = pr1.Имя;
            pr1.Произв = "ИП Радзивиловский";
            string p1 = pr1.Произв;
            pr1.Цена = 400;
            double z1 = pr1.Цена;
            pr1.Срок = 15.11;
            double s1 = pr1.Срок;
            pr1.Кол = 250;
            int k1 = pr1.Кол;


            Product pr2 = new Product();
            pr2.Имя = "батончик протеиновый";
            string i2 = pr2.Имя;
            pr2.Произв = "ООО Фитнес Фуд";
            string p2 = pr2.Произв;
            pr2.Цена = 150;
            double z2 = pr2.Цена;
            pr2.Срок =13.04;
            double s2 = pr2.Срок;
            pr2.Кол = 320;
            int k2 = pr2.Кол;

            Product pr3 = new Product();
            pr3.Имя = "Хлебцы";
            string i3 = pr3.Имя;
            pr3.Произв = "ООО Хлебпром";
            string p3 = pr3.Произв;
            pr3.Цена = 100;
            double z3 = pr3.Цена;
            pr3.Срок =21.07;
            double s3 = pr3.Срок;
            pr3.Кол = 600;
            int k3 = pr3.Кол;

            Product pr4 = new Product();
            pr4.Имя = "Шоколад";
            string i4 = pr4.Имя;
            pr4.Произв = "ООО Фитнес Фуд";
            string p4 = pr4.Произв;
            pr4.Цена = 200;
            double z4 = pr4.Цена;
            pr4.Срок =10.02;
            double s4 = pr4.Срок;
            pr4.Кол = 1540;
            int k4 = pr4.Кол;

            Product pr5 = new Product();
            pr5.Имя = "Хлебцы";
            string i5 = pr5.Имя;
            pr5.Произв = "ООО Фитнес Десерты";
            string p5 = pr5.Произв;
            pr5.Цена = 80;
            double z5 = pr5.Цена;
            pr5.Срок = 16.12;
            double s5 = pr5.Срок;
            pr5.Кол = 300;
            int k5 = pr5.Кол;

            //	список товаров для заданного наименования
            Console.WriteLine("список товаров для заданного наименования");
            Console.WriteLine("Введите имя продукта:");
            string A = Console.ReadLine();
            
            if (A == i1)
            {
                Console.WriteLine($"\nПродукт-1\nИмя:{i1}\nПроизводитель:{p1}\nЦена:{z1}\nСрок годности:{s1}\nКоличество:{k1}");
            }
            if (A == i2)
            {
                Console.WriteLine($"\nПродукт-2\nИмя:{i2}\nПроизводитель:{p2}\nЦена:{z2}\nСрок годности:{s2}\nКоличество:{k2}");
            }
            if (A == i3)
            {
                Console.WriteLine($"\nПродукт-3\nИмя:{i3}\nПроизводитель:{p3}\nЦена:{z3}\nСрок годности:{s3}\nКоличество:{k3}");
            }
            if (A == i4)
            {
                Console.WriteLine($"\nПродукт-4\nИмя:{i4}\nПроизводитель:{p4}\nЦена:{z4}\nСрок годности:{s4}\nКоличество:{k4}");
            }
            if (A == i5)
            {
                Console.WriteLine($"\nПродукт-5\nИмя:{i5}\nПроизводитель:{p5}\nЦена:{z5}\nСрок годности:{s5}\nКоличество:{k5}");
            }


            //список товаров для заданного наименования, цена которых не превышает указанной
            Console.WriteLine("Cписок товаров для заданного наименования, цена которых не превышает указанной");
            Console.WriteLine("Введите имя продукта:");
            string A1 = Console.ReadLine();
            Console.WriteLine("Введите цену max:");
            double A2 = double.Parse(Console.ReadLine());
            
            if (A1 == i1)
            {
                if(A2 > z1)
                {
                    Console.WriteLine($"\nПродукт-1\nИмя:{i1}\nПроизводитель:{p1}\nЦена:{z1}\nСрок годности:{s1}\nКоличество:{k1}");
                }
            }
            if (A1 == i2)
            {
                if (A2 > z2)
                {
                    Console.WriteLine($"\nПродукт-2\nИмя:{i2}\nПроизводитель:{p2}\nЦена:{z2}\nСрок годности:{s2}\nКоличество:{k2}");
                }
            }
            if (A1 == i3)
            {
                if (A2 > z3)
                {
                    Console.WriteLine($"\nПродукт-3\nИмя:{i3}\nПроизводитель:{p3}\nЦена:{z3}\nСрок годности:{s3}\nКоличество:{k3}");
                }
            }
            if (A1 == i4)
            {
                if (A2 > z4)
                {
                    Console.WriteLine($"\nПродукт-4\nИмя:{i4}\nПроизводитель:{p4}\nЦена:{z4}\nСрок годности:{s4}\nКоличество:{k4}");
                }
            }
            if (A1 == i5)
            {
                if (A2 > z5)
                {
                    Console.WriteLine($"\nПродукт-5\nИмя:{i5}\nПроизводитель:{p5}\nЦена:{z5}\nСрок годности:{s5}\nКоличество:{k5}");
                }
            }
            //список товаров, срок хранения которых больше заданного.
            Console.WriteLine("список товаров, срок хранения которых больше заданного");
            Console.WriteLine("Введите срок годности:");
            double A3 = double.Parse(Console.ReadLine());

            if (A3 < s1)
            {
                Console.WriteLine($"\nПродукт-1\nИмя:{i1}\nПроизводитель:{p1}\nЦена:{z1}\nСрок годности:{s1}\nКоличество:{k1}");
            }
            if (A3 < s2)
            {
                Console.WriteLine($"\nПродукт-2\nИмя:{i2}\nПроизводитель:{p2}\nЦена:{z2}\nСрок годности:{s2}\nКоличество:{k2}");
            }
            if (A3 < s3)
            {
                Console.WriteLine($"\nПродукт-3\nИмя:{i3}\nПроизводитель:{p3}\nЦена:{z3}\nСрок годности:{s3}\nКоличество:{k3}");
            }
            if (A3 < s4)
            {
                Console.WriteLine($"\nПродукт-4\nИмя:{i4}\nПроизводитель:{p4}\nЦена:{z4}\nСрок годности:{s4}\nКоличество:{k4}");
            }
            if (A3 < s5)
            {
                Console.WriteLine($"\nПродукт-5\nИмя:{i5}\nПроизводитель:{p5}\nЦена:{z5}\nСрок годности:{s5}\nКоличество:{k5}");
            }
        }
    }
}