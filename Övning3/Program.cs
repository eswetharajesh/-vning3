// See https://aka.ms/new-console-template for more information
using Övning3;

/* 3.1, Encapsulation Task */
try
{

    Console.WriteLine("3.1 Enacapsulation Task \n");
    //Person person1 = new Person(); /* Instance of person class*/

    //To create Instance of PersonHandler
    PersonHandler handler = new PersonHandler();

    //Test CreatePerson method
    Person person1 = handler.CreatePerson(30, "John", "Mykle", 175.5, 70.4);
    Console.WriteLine("person1: ");
    Console.WriteLine($"Age: {person1.Age}");
    Console.WriteLine($"First Name: {person1.FName}");
    Console.WriteLine($"Last Name: {person1.LName}");
    Console.WriteLine($"Height: {person1.Height}");
    Console.WriteLine($"Weight: {person1.Weight}");

    //Test SetAge method
    Console.WriteLine("\n\nSetting a new age using PersonHandler:");
    handler.SetAge(person1, 35);
    Console.WriteLine(handler.GetPersonInfo(person1));

    //To create another person
    Person person2 = handler.CreatePerson(18, "Lucy", "Antony", 155.5, 52.4);
    Console.WriteLine("\n\nperson2: ");
    Console.WriteLine(handler.GetPersonInfo(person2));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"An Error has occured: {ex.Message}");
}

/*3.2, Polymorphism */

Console.WriteLine("\n\n3.2 Polymorphism Task \n");

List<UserError> errors = new List<UserError>
        {
           new NumericInputError(),
           new TextInputError(),
           new SymbolError(),
           new InValidError(),
           new InSuffiecientError()
        };
foreach (UserError error in errors)
{
    Console.WriteLine(error.UEMessage());
}

/* 3.3, Inheritacne*/

Console.WriteLine("\n\n3.3 Inheritance Task \n");

List<Animal> inhertance_animals = new List<Animal>
{
    new Horse("Horse1", 500, 5, 4),
    new Dog("Tommy", 11, 4, "Husky"),
    new Hedgehog("Rosy", 30, 13, 250),
    new Worm("Spindy", 2, 30, true),
    new Wolf("Edward", 70, 26, "silver")

};

foreach (Animal animal in inhertance_animals)
{
    animal.Dosound();
}

/* 3.4, More Polymorphism*/

Console.WriteLine("\n\n3.4 Polymorphism ExtendedTask \n");

List<Animal> animals = new List<Animal>
{
    new Horse("Napier_Dog", 500, 5, 4),
    new Dog("Tommy_Dog", 11, 4, "Husky"),
    new Hedgehog("Rosy_Hedehog", 30, 13, 250),
    new Worm("Spindy_Worm", 2, 30, true),
    new Wolf("Edward_Wolf", 70, 26, "silver"),
    new Wolfman("Swetha_WolfMan",77,22,"Black")

};

foreach (Animal animal in animals)
{
    Console.WriteLine(animal.Stats());
    animal.Dosound();
    if(animal is IPerson) // 7, check if animal is person
    {
        ((IPerson)animal).Talk();    
    }
}
List<Dog> dogs = new List<Dog> //8, List of dogs
{
    new Dog("Jacky", 30, 5, "German shepherd"),
    new Dog("Bella", 25, 3, "Pug")
};

//S. 9, You cannot adda horse to the list of dogs because the list is typed for dogs(List<Dog>) 
//S.10, To store all classes,the list must be of type denoting their(classes) common Base class (Animal)

foreach(var dog in dogs)//14, Print Dog Stats
{
    if(dog is Dog)
    {
        Console.WriteLine($"Stats for Dog: {dog.Stats()}");

    }
}
foreach(var dog in dogs)//18, Accessing Custom method
{
    if(dog is Dog)
    {
        Console.WriteLine(dog.OptionalMethod());
    }
}

//S.16, No we cannot access the optional method of Dog class from the Animal list as its in type List<Animal>.
//S.17, The method is specified to the dog class(Derived class), so the Animal class(Base class) cannot access it.
//Derived class can access the methods of the Base class but the Base class cannot access the methods that are only specific to Derived class.