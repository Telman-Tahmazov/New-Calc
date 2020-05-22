using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Regres_Calculator
{
    public class SimpleCalculator
    {
        public double a;
        public double b;

        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Min(double a, double b)
        {
            return a - b;
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
        public void Menu()
        {
            Console.WriteLine("Введите первое число");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = double.Parse(Console.ReadLine());
        }
    }
}
