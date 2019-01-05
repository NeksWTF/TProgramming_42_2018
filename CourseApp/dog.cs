﻿using System;

namespace CourseApp
{
    public class Dog : Pet
    {
        public Dog()
            : base()
        {
            Weight = 50.0f;
        }

        public Dog(string n)
        {
            Pol = n;
            if (Pol == "S")
            {
                Age = 12;
                Weight = 45.0f;
            }
            else
            {
                Age = 14;
                Weight = 50.0f;
            }
        }

        public override float Weight { get; set; }

        public override int Age { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Пол: {Pol} Возраст: {Age} Вес: {Weight}");
        }

        public override string Golos()
        {
            return $"собака возраста {Age} подала голос гав-гав ";
        }

        public override string Picture()
        {
            return @" __ _ 
o'')}____// 
`_/ ) 
(_(_/-(_/";
        }

        public override string ToString()
        {
            return $"собака возраста {Age} и полом {Pol}";
        }
    }
}