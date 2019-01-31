using System;
using System.Collections.Generic;

namespace Classes
{
    class CarShop
    {
        string _name;
        public string Name { get => _name; set => _name = value; }

        List<Car> _propositions;

        public CarShop(string name)
        {
            _propositions = new List<Car>();
            Name = name;
        }

        public void AddCar(Car car)
        {
            _propositions.Add(car);
        }

        public void AddCar(string mark, string color, int price)
        {
            Car car = new Car(mark, color, price);
            _propositions.Add(car);
        }

        public Car SellCar(int num, Human newOwner)
        {
            _propositions[num - 1].Owner = newOwner;
            Car tmp = _propositions[num - 1];
            _propositions.RemoveAt(num - 1);
            Console.WriteLine("Сделка совершена.");
            return tmp;
        }

        public void ShowPropos()
        {
            Console.WriteLine($"Автосалон {Name}. В продаже: ");
            for (int i = 0; i < _propositions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_propositions[i]}");
            }
        }
    }
}
