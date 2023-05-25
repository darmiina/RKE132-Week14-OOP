// Klassi loomine, objekti õpetama tegema midagi

Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog("Good Girl"); 

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy"); // Koera nime ümbernimetamiseks

while (myDog.levelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name = "Koer"; //field
    private int _levelOfHappiness; //field

    // Constructor
    public Dog(string name) // name - let the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }
    //getter
    public string Name
    {
        get { return _name; }
    }
    // getter
    public int levelOfHappiness
    {
        get { return _levelOfHappiness; }
    }
    public void Rename(string newName) // Meetod nime vahetamiseks
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}

