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
            int n = Convert.ToInt32(Console.ReadLine());

            int SumNumber(int c)
            {

                int counter = Convert.ToString(n).Length;
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

            int sumNumber = SumNumber(n);
            Console.WriteLine("Сумма цифр в числе: " + sumNumber);


            // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
            // 6, 1, 33 -> [6, 1, 33]

            Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
            Console.Write("Введите ряд чисел, разделенных запятой : ");
            string seriesOfNumbers = Console.ReadLine();

            seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

            // функция удаления пробелов из строки 
            string RemovingSpaces(string series)
            {
                string SeriesNew = "";
                for (int i = 0; i < series.Length; i++)
                {
                    if (series[i] != ' ')
                    {
                        SeriesNew += series[i];
                    }
                }
                return SeriesNew;
            }

            //  функция  проверки на правильность ввода 
            void СheckNumber2(int series)
            {

                if (series == '0' || series == '1' || series == '2'
                || series == '3' || series == '4' || series == '5' || series == '6'
                || series == '7' || series == '8' || series == '9' || series == ','
                || series == '-')
                {
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

                }
            }

            // функция  создания и заполнения массива из строки
            int[] ArrayOfNumbers(string SeriesNew)
            {

                int[] array = new int[1];    // инициализация массива из 1 элемента

                int j = 0;

                for (int i = 0; i < SeriesNew.Length; i++)
                {
                    string seriesNew1 = "";

                    while (SeriesNew[i] != ',' && i < SeriesNew.Length)
                    {
                        seriesNew1 += SeriesNew[i];
                        СheckNumber2(SeriesNew[i]);
                        i++;
                    }
                    array[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
                    if (i < SeriesNew.Length - 1)
                    {
                        array = array.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
                    }
                    j++;
                }
                return array;
            }

            // функция  вывода массива на печать 
            void PrintArry(int[] coll)
            {
                int count = coll.Length;
                int index = 0;
                Console.Write("[");
                while (index < count)
                {
                    Console.Write(coll[index]);
                    index++;
                    if (index < count)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("]");
            }


            string seriesNew = RemovingSpaces(seriesOfNumbers);

            int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

            PrintArry(arrayOfNumbers);






        }

    } 

}
