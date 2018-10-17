//Odzeli
//а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и 
//    заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которые возвращают сумму элементов массива,
//    метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, 
//    свойство MaxCount, возвращающее количество максимальных элементов.В Main продемонстрировать работу класса.
//б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
using System;
using System.Collections;
using System.IO;

namespace homeWork4
{
    public class Task4WorkWithArray : IEnumerable
    {
        public int[] Array { get; private set; }
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int a in Array)
                {
                    sum += a;
                }
                return sum;
            }
        }
        private string _path;
        //свойство MaxCount, возвращающее количество максимальных элементов - я не совсем понял суть этого задания. 
        //Если он неправильно работает, значит я неправильно понял задание, потому что он работает правильно относительно того как я понял.
        public int MaxCount
        {
            get
            {
                int maxCount = 0;
                int maxElement = 0;
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] > maxElement)
                    {
                        maxElement = Array[i];
                    }
                }
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] == maxElement)
                    {
                        maxCount++;
                    }
                }
                return maxCount;
            }
        }

        public Task4WorkWithArray(int dimension, int initialValue, int step)
        {
            Array = new int[dimension];
            var numberWithStep = initialValue;
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = numberWithStep;
                numberWithStep += step;
            }
        }

        public Task4WorkWithArray(string pathToFile)
        {
            _path = pathToFile;
            ReadFromFile();
        }

        public void ReadFromFile()
        {
            try
            {
                StreamReader reader = new StreamReader(_path);
                string line;
                int lengthSymbol = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    lengthSymbol++;
                }
                Array = new int[lengthSymbol];
                reader.BaseStream.Position = 0; ;
                for (int i = 0; i < lengthSymbol; i++)
                {
                    Array[i] = int.Parse(reader.ReadLine());
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void WriteToFile(string path)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path);
                for (int i = 0; i < Array.Length; i++)
                {
                    writer.WriteLine(Array[i]);
                }
                writer.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Inverse()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] *= -1;
            }
        }

        public void Multi(int multiplier)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] *= multiplier;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Array.GetEnumerator();
        }

    }
}
