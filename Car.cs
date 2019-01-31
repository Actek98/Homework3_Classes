using System;

namespace Classes
{
    class Car
    {
        string _mark;
        public string Mark { get => _mark; set => _mark = value; }

        string _color;
        public string Color { get => _color; set => _color = value; }

        int _price;
        public int Price { get => _price; set => _price = value; }

        public Human Owner { get; set; }

        public Car(string mark, string color, int price)
        {
            Mark = mark;
            Color = color;
            Price = price;
        }

        public override string ToString()
        {
            string owner = Owner!=null? ", владелец: " + Owner.FirstName + " " + Owner.LastName : "";
            return $"Марка машины: {Mark}, цвет: {Color}, цена: {Price}${owner}.";
        }
    }
}
