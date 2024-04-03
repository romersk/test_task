using System;

public class Enclosure
{
    public string Type { get; set; }
    public int NumberOfAnimals { get; set; }
    public Animal[] Animals { get; set; }

    public Enclosure(string type, int numberOfAnimals, Animal[] animals)
    {
        Type = type;
        NumberOfAnimals = numberOfAnimals;
        Animals = animals;
    }

    public void ApproachEnclosure()
    {
        Console.WriteLine($"Сейчас в вольере {Type}. Их количество - {NumberOfAnimals}.");
        Console.WriteLine("Из них:");
        foreach (Animal animal in Animals)
        {
            animal.MakeSound();
        }
    }
}
