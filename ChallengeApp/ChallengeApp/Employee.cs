﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.age = age;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int age { get; private set; }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public string Info
        {
            get
            {
                return "Najlepszy wynik uzyskał/ła: " + this.Name + " " + this.Surname + " Wynik: " + this.Result;
            }
        }
    }
}
