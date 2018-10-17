//Odzeli
//1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
//В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
using System;

namespace homeWork4
{
    partial class Program
    {
        private static void FirstTask()
        {
            int count = 0;
            int[] myArray = FillRandomArray(5, -10000, 10000);
            for (int i = 0; i < myArray.Length-1; i++)
            {
                int j = i+1;
                bool firstNumberIsValid = myArray[i] % 3 == 0;
                bool secondNumberIsValid = myArray[j] % 3 == 0;
                if (firstNumberIsValid || secondNumberIsValid)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество пар элементов массива, в которых хотя бы одно число делится на 3: {count}");
        }

        private static int[] FillRandomArray(int arrayDimension, int min, int max)
        {
            int[] myArray = new int[arrayDimension];
            Random randomValue = new Random();
            for (int i = 0; i < arrayDimension; i++)
            {
                myArray[i] = randomValue.Next(min, max);
            }
            return myArray;
        }
    }
}
