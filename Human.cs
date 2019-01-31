using System;

namespace Classes
{
    class Human
    {
        string _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }

        string _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }

        int _birthdayYear;

        Car _car;

        public int Age
        {
            set
            {
                _birthdayYear = DateTime.Now.Year - value;
            }
            get
            {
                return DateTime.Now.Year - _birthdayYear;
            }
        }

        public Human(string firstName, string lastName, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void BuyCar(int num, CarShop carShop)
        {
            _car = carShop.SellCar(num, this);
            Console.WriteLine($"{FirstName} {LastName} в магазине {carShop.Name} купил машину: \n {_car} ");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} лет.";
        }

        public virtual void Eat()
        {
            Console.Write($"{FirstName} ест.");
        }

        public virtual void Sleep(int time)
        {
            Console.Write($"{FirstName} спит {time / 60} часов, {time % 60}минут.");
        }
    }
}
