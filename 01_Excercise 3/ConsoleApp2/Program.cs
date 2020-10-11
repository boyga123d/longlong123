using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace ConsoleApp1
{
    class Program
    {
        interface IAnimal
        {
            public DateTime BirthDate();
            public void Move() { }
            public void Speak() { }
        }
        interface BaseIAnimal : IAnimal
        {
            public DateTime BirthDate()
            {
                throw new NotImplementedException();
            }
            public void Move() { }
            public void Speak() { }
        }

        class Monkey : BaseIAnimal
        {
            public DateTime BirthDate()
            {
                throw new NotImplementedException();
            }
            public void Move()
            {
                Console.WriteLine(" move with hand");
            }
            public void Speak()
            {
                Console.WriteLine(" speak kec...kec...kec");
            }
            public void Climb()
            {
                Console.WriteLine("Fast climb");
            }
        }
        interface Pet : BaseIAnimal
        {
            public void Move() { }
            public void Speak() { }
            public DateTime BirthDate()
            {
                throw new NotImplementedException();
            }


        }
        class Cat : Pet
        {
            public DateTime BirthDate()
            {
                throw new NotImplementedException();
            }
            public void jump()
            {
                Console.Write(" jump 5 feet");
            }
            public void Move()
            {
                Console.Write(" Di chuyen = chan , di hoac chay nhay");
            }
            public void Speak()
            {
                Console.Write("\n speak meow...meow");
            }
        }
        class Dog : Pet
        {
            public DateTime BirthDate()
            {
                throw new NotImplementedException();
            }
            public string Color { get; set; }
            public void Move()
            {
                Console.Write(" Di chuyen = chan , di hoac chay chay");
            }
            public void Speak()
            {
                Console.Write("\n speak rolf... rolf... rolf");
            }
        }
        static void Main(string[] args)
        {
            List<IAnimal> Animals = new List<IAnimal>();
            Console.Write("Input number of animals: ");
            int n = int.Parse(Console.ReadLine());
            int c;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1.Dog 2.Cat 3.Monkey\nChoose kind of animal: ");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Animals.Add(new Dog()); break;
                    case 2:
                        Animals.Add(new Cat()); break;
                    case 3:
                        Animals.Add(new Monkey()); break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n========= Animal " + (i + 1));
                Animals[i].Move();
                Animals[i].Speak();              
            }
        }
    }
}