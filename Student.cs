using System;

namespace Classes
{
    class Student: Human
    {
        string _university;
        public string University { get => _university; set => _university = value; }

        int _kurs;
        public int Kurs { get => _kurs; set => _kurs = value; }

        public Student(string firstName, string lastName, byte age, string university, int kurs) : base(firstName, lastName, age)
        {
            University = university;
            Kurs = kurs;
        }

        public void Study(int time, string subject)
        {
            Console.Write($"{FirstName} учится в течении {time / 60} часов, {time % 60}минут.");
        }

        public override void Eat()
        {
            Console.Write($"{FirstName} не ест. Студент не нуждается в еде.");
        }


        public override void Sleep(int time = 0)
        {
            Console.Write($"{FirstName} не спит. Студент не нуждается в сне.");
        }
    }
}
