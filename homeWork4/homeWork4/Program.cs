//Odzeli
using System;
using static homeWork4.Logining;

namespace homeWork4
{
    partial class Program
    {


        static void Main(string[] args)
        {
            //FirstTask();
            //var array = new Task4WorkWithArray(5, 5, 5);
            //array.WriteToFile(@"D:\data.txt");
            //var arrayFromFile = new Task4WorkWithArray(@"D:\data.txt");
            string userName = "archil";
            string password = "odzelii";
            Account user;
            user.Login = new string[userName.Length];
            for (int i = 0; i < userName.Length; i++)
            {
                user.Login[i] = userName[i].ToString();
            }
            user.Password = new string[password.Length];
            for (int i = 0; i < password.Length; i++)
            {
                user.Password[i] = password[i].ToString();
            }

            Logining userLogining = new Logining(user);
            userLogining.CheckLogin(@"D:\login.txt");
            userLogining.CheckPassword(@"D:\password.txt");

            Console.ReadKey();
        }
    }
}
