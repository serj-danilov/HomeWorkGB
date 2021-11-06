using System;

namespace Lesson01
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Данилов Сергей Владимирович, курс Unity

            #region Задача 1
            Console.Write("Введите Ваше имя:");
            string fName = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите Вашу фамилию:");
            string sName = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите сколько Вам лет:");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Введите Ваш рост:");
            int growth = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Введите Ваш вес:");
            int weith = int.Parse(Console.ReadLine());
            Console.Clear();



            Console.WriteLine(fName + " " + sName + " " + age + " " + growth + " " + weith );

            Console.WriteLine("Ваше Имя: {0}, Ваша Фамилия: {1}, Ваш возраст: {2}, Ваш рост: {3}, Ваш вес: {4}", fName, sName, age, growth, weith);

            Console.WriteLine($"Your First Name {fName}, Your Second Name {sName}, Your age {age}, Your growth {growth}, Your weith {weith}");


            Console.ReadLine();





            #endregion



            #region Задача 2

            Console.Clear();
            Console.Write("Введите рост в метрах:");
            double h = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Введите вес в КГ:");
            int m = int.Parse(Console.ReadLine());
            Console.Clear();

            double I = m / (h * h);

            var itog = Math.Truncate(I);

            Console.WriteLine(itog);

            Console.ReadLine();


            #endregion



            #region Задача 3

            Console.Clear();

            int x1 = 10;
            int y1 = 10;
            int x2 = 5;
            int y2 = 5;

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            itog = Math.Round(r, 2);

            Console.WriteLine("Расстояние между точками = " + itog);

            Console.ReadLine();

            #endregion




            #region Задача 3* - Так и не разобрался :(

          /*  Console.Clear();

            static double MathSqrt (double _x1, double _y1, double _x2, double _y2)
            {

                double x1 = _x1;
                double y1 = _y1;
                double x2 = _x2;
                double y2 = _y2;

                double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double itog = Math.Round(r, 2);

                return itog;

            }

            Console.WriteLine("Расстояние между точками = " + MathSqrt(8,8,3,3));

            Console.ReadLine (); */

            #endregion


        }
    }
}
