using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public abstract void Dosound();
        public Animal(string name, double weight, int age) //constructor
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
        public virtual string Stats() // 1, New stats override method (3.4)
        {
            return $"Name: {Name}, Weight: {Weight} kg, Age: {Age} years";
        }
    }
    public class Horse : Animal
    {
        public int NumberOfHooves { get; set; }
        public Horse(string name, double weight, int age, int hooves) : base(name, weight, age)
        {
            NumberOfHooves = hooves;
        }
        public override void Dosound()
        {
            Console.WriteLine("The horse makes a neighing sound.");
        }
        public override string Stats()
        {
            return base.Stats() + $", Hooves: {NumberOfHooves}";
        }

    }
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void Dosound()
        {
            Console.WriteLine("The dog barks.");
        }
        public override string Stats()
        {
            return base.Stats() + $", Breed: {Breed}";
        }

        public string OptionalMethod() //15, New optional method(3.4)
        {
            return "This is an optional method that returns only string";
        }
    }
    public class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }
        public Hedgehog(string name, double weight, int age, int spikes) : base(name, weight, age)
        {
            NumberOfSpikes = spikes;
        }
        public override void Dosound()
        {
            Console.WriteLine("The hedgehog makes a rustling sound.");
        }
        public override string Stats()
        {
            return base.Stats() + $", Spikes: {NumberOfSpikes}";
        }
    }
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age, bool poison) : base(name, weight, age)
        {
            IsPoisonous = poison;
        }
        public override void Dosound()
        {
            Console.WriteLine("The worm squirms silently.");
        }
        public override string Stats()
        {
            return base.Stats() + $", Poison: {IsPoisonous}";
        }
    }
   
    public class Wolf : Animal
    {
        public string FurColor { get; set; }
        public Wolf(string name, double weight, int age, string furColor) : base(name, weight, age)
        {
            FurColor = furColor;
        }
        public override void Dosound()
        {
            Console.WriteLine("The wolf howls.");
        }
        public override string Stats()
        {
            return base.Stats() + $", FurColor: {FurColor}";
        }

    }

    //S 14,: We can add new attributes to all the animals in the animal class.(3.3)

}
