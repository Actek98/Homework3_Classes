using System;

namespace Classes
{
    class Lecture: Human
    {
        string _university;
        public string University { get => _university; set => _university = value; }

        string _subject;
        public string Subject { get => _subject; set => _subject = value; }

        public Lecture(string firstName, string lastName, byte age, string university, string subject) : base(firstName, lastName, age)
        {
            Subject = subject;
            University = university;
        }

        public void Work(int time)
        {
            Console.Write($"Преподаватель {FirstName} обучает студентов {time / 60} часов, {time % 60}минут.");
        }
    }
}
