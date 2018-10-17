//Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
//Создайте структуру Account, содержащую Login и Password.
using System;
using System.IO;

namespace homeWork4
{
    public class Logining
    {
        private Account rightUserData;

        public struct Account
        {
            public string[] Login;
            public string[] Password;
        }
        public Logining(Account account)
        {
            rightUserData = account;
        }

        public void CheckLogin(string path)
        {
            {
                try
                {
                    Account user;
                    StreamReader reader = new StreamReader(path);
                    string line;
                    int lengthSymbol = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lengthSymbol++;
                    }
                    user.Login = new string[lengthSymbol];
                    reader.BaseStream.Position = 0; ;
                    for (int i = 0; i < lengthSymbol; i++)
                    {
                        user.Login[i] = reader.ReadLine();
                    }
                    reader.Close();
                    if (checkArray(rightUserData.Login, user.Login))
                    {
                        Console.WriteLine("Логин правильный.");
                    }
                    else
                    {
                        Console.WriteLine("Логин неверный.");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void CheckPassword(string path)
        {
            {
                try
                {
                    Account user;
                    StreamReader reader = new StreamReader(path);
                    string line;
                    int lengthSymbol = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lengthSymbol++;
                    }
                    user.Password = new string[lengthSymbol];
                    reader.BaseStream.Position = 0; ;
                    for (int i = 0; i < lengthSymbol; i++)
                    {
                        user.Password[i] = reader.ReadLine();
                    }
                    reader.Close();
                    if (checkArray(rightUserData.Password, user.Password))
                    {
                        Console.WriteLine("Пароль верный.");
                    }
                    else
                    {
                        Console.WriteLine("Пароль неверный.");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }


        private bool checkArray(string[] firstArray, string[] secondArray)
        {
            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        return false;
                    }
                }
            return true;
            }
            return false;
        }
    }
}
