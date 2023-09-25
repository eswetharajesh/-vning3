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
        public Wolfman(string name, double weight, int age, string furColor) : base(name, weight, age, furColor)
        {
        }
        public void Talk()
        {
            Console.WriteLine("WolfMan says, I'm a human-wolf hybrid.");
        }
    }
}
