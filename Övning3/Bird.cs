using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    public class Bird : Animal //Inherited from animal class
    {
        public double WingSpan { get; set; }
        public Bird(string name, double weight, int age, double wing) : base(name, weight, age)
        {
            WingSpan = wing;
        }
        public override void Dosound()
        {
            Console.WriteLine("The bird chirps.");
        }
         public override string Stats()
        {
            return base.Stats() + $", Wing: {WingSpan}";
        }
    }
    public class Pelican : Bird // Inherited from subclass named Bird
    {
        public string BeakColor { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, string beakColor) : base(name, weight, age, wingSpan)
        {
            BeakColor = beakColor;
        }
        public override string Stats()
        {
            return base.Stats() + $", Beakcolor: {BeakColor}";
        }
    }
    public class Flamingo : Bird
    {
        public double LegLength { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, double legLength) : base(name, weight, age, wingSpan)
        {
            LegLength = legLength;
        }
         public override string Stats()
        {
            return base.Stats() + $", Leglength: {LegLength}";
        }
    }
    public class Swan : Bird
    {
        public double NeckLength { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, double neckLength) : base(name, weight, age, wingSpan)
        {
            NeckLength = neckLength;
        }
         public override string Stats()
        {
            return base.Stats() + $", Necklength: {NeckLength}";
        }
    }
}
//S.13, We can add new attributes to all the birds in the bird class.(3.3)
