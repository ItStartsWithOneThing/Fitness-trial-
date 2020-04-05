using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Fitness.BL.Controller;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую тебя, буженина. Это приложение ProFitness");
            Thread.Sleep(2000);

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();
            Thread.Sleep(1000);

            Console.WriteLine("Введите ваш пол");
            var gender = Console.ReadLine();
            Thread.Sleep(1000);

            Console.WriteLine("Введите вашу дату рождения");
            var birthDate = DateTime.Parse(Console.ReadLine()); // TODO: Переписать на трайпарс
            Thread.Sleep(1000);

            Console.WriteLine("Введите ваш вес");
            var weight = double.Parse(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("Введите ваш рост");
            var height = double.Parse(Console.ReadLine());
            Thread.Sleep(1000);

            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();
        }
    }
}
