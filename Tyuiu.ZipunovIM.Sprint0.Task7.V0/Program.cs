// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

using System;
using Tyuiu.ZipunovIM.Sprint0.Task7.V0.Lib;

namespace Tyuiu.ZipunovIM.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Зипунов И.М. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СPRINT #0                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения         *");
            Console.WriteLine("* двух одинаковых массивов по длине.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // 1. Объявляем два исходных массива
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            // 2. Выводим первый массив
            Console.WriteLine("Значение элементов массива №1:");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + " ");
            }
            Console.WriteLine();

            // 3. Выводим второй массив
            Console.WriteLine("Значение элементов массива №2:");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // 4. Вызываем созданный ранее метод из библиотеки
            int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

            // 5. Выводим результат сложения
            Console.WriteLine("Сумма элементов массива равна:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}