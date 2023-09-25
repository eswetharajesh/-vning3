using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    public class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }
        public Person CreatePerson(int age,string fName, string lName, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fName;
            person.LName = lName;
            person.Height = height;
            person.Weight = weight;
            return person;
        }
        public string GetPersonInfo(Person person) => $"First Name: {person.FName},\nLast Name: {person.LName},\nAge: {person.Age},\nHeight: {person.Height},\nWeight: {person.Weight}";
    }
}
