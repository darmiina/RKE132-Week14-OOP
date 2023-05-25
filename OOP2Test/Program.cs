﻿// Loo kassi klass. Kassil on nimi, värv ja omadus, mis näitab kasii näljasust.
// Vaikimisi kassi loomisel, kassil on kõht täis (_bellyFull võrdub 10).
// Peale loomist, kass läheb magama. Mida kauem kass magab, seda tühjemaks tal kõht läheb.
// Kui _bellyFull jõuab nullini, siis kass ärkab üles ja ütleb "Meow".

Cat newCat = new Cat ("Garfield", "ginger");
Console.WriteLine($"{newCat.Name} wants a rub on its belly.");

while (newCat.BellyFull > 0)
{
    newCat.Sleep();
}
newCat.Meow();
newCat.ShowCatData();

class Cat
{
    private string _name;
    private string _color;
    private int _bellyFull;
public Cat(string name, string color)
{
    _name = name;
        _color = color;
        _bellyFull = 10;
    Console.WriteLine($"A {color} cat {name} has been created.");
}

public string Name //getter
    {  
get  { return _name; }
    }
public int BellyFull //getter
   { 
    get { return _bellyFull; }
    }
    public void Sleep()
{
    _bellyFull--;
    Console.WriteLine($"{_name} says: Z-z-Z-z-Z-z");
}
public void Meow()
{
    Console.WriteLine($"{_name} says: Meow!");
}
public void ShowCatData() //displays info about the cat object
{
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine($"Color: {_color}");
    Console.WriteLine($"Level of hungriness: {_bellyFull}");
}
}
