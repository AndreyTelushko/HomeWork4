using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SquareNumber(int a, int b)
            {
                int result = 1;
                for (int i = 1; i <= b; i++)
                {
                    result = result * a;
                }
                return result;
            }
            Console.WriteLine("Возведение числа в натуральную степень.");
            Console.Write("Введите число: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int squarenumber = SquareNumber(numberA, numberB);
            Console.WriteLine("Ответ: " + squarenumber);



            Console.WriteLine($"Сумма цифр в числе");
            Console.Write("Введите число N: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            int SumNumber(int n)
            {

                int counter = Convert.ToString(numberN).Length;
                int advance = 0;
                int result = 0;

                for (int i = 0; i < counter; i++)
                {
                    advance = n - n % 10;
                    result = result + (n - advance);
                    n = n / 10;
                }
                return result;
            }

            int sumNumber = SumNumber(numberN);
            Console.WriteLine("Сумма цифр в числе: " + sumNumber);
        }

    }

}
