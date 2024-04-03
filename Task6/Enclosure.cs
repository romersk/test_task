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
        Console.WriteLine($"�� ������� � ������� � {Type}. � ������� ��������� {NumberOfAnimals} ��������.");
        Console.WriteLine("����� ��������:");
        foreach (Animal animal in Animals)
        {
            animal.MakeSound();
        }
    }
}