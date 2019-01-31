using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShop carShop = new CarShop("Автомаг");
            Student student1 = new Student("Джек", "Дэниелс", 18, "ДНУЖТ", 4);
            Lecture lector1 = new Lecture("Вадим", "Степнов", 25, "ДНУЖТ", "Базы данных");
            Human human1 = new Human("Артем", "Круглов", 14);
            Console.WriteLine("{0}\n{1}\n{2}\n", human1, student1, lector1);

            carShop.AddCar("Alfa Romeo", "Красный", 10000);
            carShop.AddCar("Bentley", "Черный", 100000);
            carShop.ShowPropos();
            Console.Write("Введите ваш выбор: ");
            lector1.BuyCar(int.Parse(Console.ReadLine()), carShop);
            Console.WriteLine();
            carShop.ShowPropos();

            Console.ReadKey();
        }
    }
}
