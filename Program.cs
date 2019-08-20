using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double b,c;
            Console.WriteLine("Введите первое число");
            string chislo = Console.ReadLine();
            double a = double.Parse(chislo);
            Console.WriteLine("Введите второе число");
            chislo = Console.ReadLine();
            double.TryParse(chislo, out b);
            Console.WriteLine("Введите третье число");
            chislo = Console.ReadLine();
            double.TryParse(chislo, out c);
            Console.WriteLine("сумма чисел= " + (a + b + c));
            Console.WriteLine("Произведение чисел= " + (a * b * c));
        }
    }
}
