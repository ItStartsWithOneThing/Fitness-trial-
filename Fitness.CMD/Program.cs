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

            

            var userController = new UserController(name);
            if(userController.IsNewUser)
            {
                Console.WriteLine("Введите пол: ");

                var gender = Console.ReadLine();

                DateTime birthDate = ParseDateTime();

                double weight = ParseDouble("Вес");

                double height = ParseDouble("Рост");
                                userController.SetNewUserData(gender, birthDate, weight, height);
            }

            Console.WriteLine(userController.CurrentUser);

            Console.ReadLine();
        }

        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.WriteLine("Введите дату рождения: ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверный формат {name}");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.WriteLine($"Введите {name}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Неверный формат {name}");
                }
            }
        }
    }
}
