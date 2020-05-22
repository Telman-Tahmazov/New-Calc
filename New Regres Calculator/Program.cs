using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Regres_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator Calk = new SimpleCalculator();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите одно из условий: \n 1. Сложение \n 2. Вычетание \n 3. Умножение \n 4. Деление \n 5. Квадратный корень числа ");

                switch (Console.ReadLine())
                {
                    case "1":
                        try
                        {
                            Calk.Menu();
                            Console.WriteLine($"Результат: {Calk.Sum(Calk.a, Calk.b)}");                           
                        }
                        catch(Exception Exp)
                        {
                            Console.WriteLine($"Ошибка {Exp.Message}");
                        }
                        break;
                    case "2":
                        try
                        {
                            Calk.Menu();
                            Console.WriteLine($"Результат: {Calk.Min(Calk.a, Calk.b)}");
                        }
                        catch (Exception Exp)
                        {
                            Console.WriteLine($"Ошибка {Exp.Message}");
                        }
                        break;

                    case "3":
                        try
                        {
                            Calk.Menu();
                            Console.WriteLine($"Результат: {Calk.Mult(Calk.a, Calk.b)}");
                        }
                        catch (Exception Exp)
                        {
                            Console.WriteLine($"Ошибка {Exp.Message}");
                        }
                        break;
                    case "4":
                        try
                        {
                            Calk.Menu();
                            Console.WriteLine($"Результат: {Calk.Div(Calk.a, Calk.b)}");
                        }
                        catch (Exception Exp)
                        {
                            Console.WriteLine($"Ошибка {Exp.Message}");
                        }
                        break;
                    case "5":
                        try
                        {
                            Console.WriteLine("Введите число");
                            Calk.a = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Результат: {Calk.Sqrt(Calk.a)}");
                        }
                        catch (Exception Exp)
                        {
                            Console.WriteLine($"Ошибка {Exp.Message}");
                        }
                        break;

                }
                Console.ReadKey();

            }



        }
    }
}
