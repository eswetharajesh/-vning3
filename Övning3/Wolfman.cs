using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    public class Wolfman : Wolf, IPerson
    {
        public string EyeColor {  get; set; }
        public Wolfman(string name, double weight, int age, string furColor, string eyeColor) : base(name, weight, age, furColor)
        {
            EyeColor = eyeColor;
        }
        public void Talk()
        {
            Console.WriteLine("Wolfman says: I'm a human-wolf hybrid. I'm a Vampire!");
        }
    }
}
