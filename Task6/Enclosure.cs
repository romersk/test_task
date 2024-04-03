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
        Console.WriteLine($"Вы подошли к вольеру с {Type}. В вольере находится {NumberOfAnimals} животных.");
        Console.WriteLine("Звуки животных:");
        foreach (Animal animal in Animals)
        {
            animal.MakeSound();
        }
    }
}