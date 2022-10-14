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
        public static Product[] myMassive = new Product[5];

        private static void checkName(string A) {
            for (uint i = 0; i < myMassive.Length; i++)
            {
                if (A == myMassive[i].Имя)
                {
                    Console.WriteLine($"\nПродукт-1\nИмя:{myMassive[i].Имя}\nПроизводитель:{myMassive[i].Произв}\n" +
                        $"Цена:{myMassive[i].Цена}\nСрок годности:{myMassive[i].Срок}\nКоличество:{myMassive[i].Кол}");
                }
            }
        }

        private static void init() {
            Product pr1 = new Product();
            pr1.Имя = "паста арахисовая";
            string i1 = pr1.Имя;
            pr1.Произв = "ИП Радзивиловский";
            string p1 = pr1.Произв;
            pr1.Цена = 400;
            double z1 = pr1.Цена;
            pr1.Срок = new DateTime(2022, 04, 13);
            DateTime s1 = pr1.Срок;
            pr1.Кол = 250;
            int k1 = pr1.Кол;


            Product pr2 = new Product();
            pr2.Имя = "батончик протеиновый";
            string i2 = pr2.Имя;
            pr2.Произв = "ООО Фитнес Фуд";
            string p2 = pr2.Произв;
            pr2.Цена = 150;
            double z2 = pr2.Цена;
            pr2.Срок = new DateTime(2022, 09, 05);
            DateTime s2 = pr2.Срок;
            pr2.Кол = 320;
            int k2 = pr2.Кол;

            Product pr3 = new Product();
            pr3.Имя = "Хлебцы";
            string i3 = pr3.Имя;
            pr3.Произв = "ООО Хлебпром";
            string p3 = pr3.Произв;
            pr3.Цена = 100;
            double z3 = pr3.Цена;
            pr3.Срок = new DateTime(2022, 02, 10);
            DateTime s3 = pr3.Срок;
            pr3.Кол = 600;
            int k3 = pr3.Кол;

            Product pr4 = new Product();
            pr4.Имя = "Шоколад";
            string i4 = pr4.Имя;
            pr4.Произв = "ООО Фитнес Фуд";
            string p4 = pr4.Произв;
            pr4.Цена = 200;
            double z4 = pr4.Цена;
            pr4.Срок = new DateTime(2022, 07, 23);
            DateTime s4 = pr4.Срок;
            pr4.Кол = 1540;
            int k4 = pr4.Кол;

            Product pr5 = new Product();
            pr5.Имя = "Хлебцы";
            string i5 = pr5.Имя;
            pr5.Произв = "ООО Фитнес Десерты";
            string p5 = pr5.Произв;
            pr5.Цена = 80;
            double z5 = pr5.Цена;
            pr5.Срок = new DateTime(2021, 12, 17);
            DateTime s5 = pr5.Срок;
            pr5.Кол = 300;
            int k5 = pr5.Кол;

            myMassive[0] = pr1;
            myMassive[1] = pr2;
            myMassive[2] = pr3;
            myMassive[3] = pr4;
            myMassive[4] = pr5;
        }
        static uint Search(string searchName) {
            for (uint i = 0; i < myMassive.Length;i++) {
                if (searchName == myMassive[i].Имя)
                {
                    return i;
                }                
            }
            return 0;
        }
        static void Main(string[] args)
        {

            init();

            //	список товаров для заданного наименования
            Console.WriteLine("список товаров для заданного наименования");
            Console.WriteLine("Введите имя продукта:");
            string A = Console.ReadLine();


            checkName(A);
            /*
            for (uint i = 0; i < myMassive.Length; i++) {
                if (A == myMassive[i].Имя)
                {
                    Console.WriteLine($"\nПродукт-1\nИмя:{myMassive[i].Имя}\nПроизводитель:{myMassive[i].Произв}\n" +
                        $"Цена:{myMassive[i].Цена}\nСрок годности:{myMassive[i].Срок}\nКоличество:{myMassive[i].Кол}");
                }
            }
           */


            //список товаров для заданного наименования, цена которых не превышает указанной
            Console.WriteLine("Cписок товаров для заданного наименования, цена которых не превышает указанной");
            Console.WriteLine("Введите имя продукта:");
            string A1 = Console.ReadLine();
            Console.WriteLine("Введите цену max:");
            double A2 = double.Parse(Console.ReadLine());

            for (uint i = 0; i < myMassive.Length; i++)
            {
                if (A1 == myMassive[i].Имя && A2 > myMassive[i].Цена)
                {
                    Console.WriteLine($"\nПродукт-1\nИмя:{myMassive[i].Имя}\nПроизводитель:{myMassive[i].Произв}\nЦена:{myMassive[i].Цена}" +
                        $"\nСрок годности:{myMassive[i].Срок}\nКоличество:{myMassive[i].Кол}");
                }
            }
    
            //список товаров, срок хранения которых больше заданного.
            Console.WriteLine("список товаров, срок хранения которых больше заданного");
            Console.WriteLine("Введите срок годности:");
            DateTime A3 = new DateTime();

            A3 = DateTime.Parse(Console.ReadLine());
            /* переделать
            if (A3 < s1)
            {
                Console.WriteLine($"\nПродукт-1\nИмя:{i1}\nПроизводитель:{p1}\nЦена:{z1}\nСрок годности:{s1}\nКоличество:{k1}");
            }*/

        }
    }
}