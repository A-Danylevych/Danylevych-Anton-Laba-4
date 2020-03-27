using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP2._4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public abstract class Pet
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public int Age { get; private set; }

        public abstract void Voice();
        public abstract void Go();
        public Pet(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
    }
    public abstract class Bird : Pet
    {
        public abstract void Fly();
        public int Winglength { get; private set; }
        public Bird(string name, string color, int age, int winglength) : base(name, color, age)
        {
            Winglength = winglength;
        }
    }
    public class Dog:Pet
    {
        public string Breed { get; private set; }
        public override void Voice()
        {
            Console.WriteLine("woof-woof");
        }
        public void ProtectHouse()
        {
            Console.WriteLine("Dog is protectiong your house");
        }
        public override void Go()
        {
            Console.WriteLine("Dog is going");
        }
        public Dog(string name,string color,int age,string breed):base(name,color,age)
        {
            Breed = breed;
        }
    }
    public class Cat : Pet
    {
        public string Breed { get; private set; }
        public override void Voice()
        {
            Console.WriteLine("meow");
        }
        public void TurnOnVibration()
        {
            Console.WriteLine("Vibration is turned on");
        }
        public void TurnOffVibration()
        {
            Console.WriteLine("Vibration is turned off");
        }
        public override void Go()
        {
            Console.WriteLine("Dog is going");
        }
        public Cat(string name, string color, int age, string breed) : base(name, color, age)
        {
            Breed = breed;
        }
    }
    public class Scarecrow : Bird
    {
        public string CellType { get; private set; }
        public override void Fly()
        {
            Console.WriteLine("Scarecrow is flying");
        }
        public override void Go()
        {
            Console.WriteLine("Scarecrow is going");
        }
        public override void Voice()
        {
            Console.WriteLine("ZVIRIN'-ZVIRIN'");
        }
        public Scarecrow(string name,string color,int age,int winglength,string cellType) : base(name, color, age,winglength)
        {
            CellType = cellType;
        }
    }
}
