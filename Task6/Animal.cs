using System;

public class Animal
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Sound { get; set; }

    public Animal(string name, string gender, string sound)
    {
        Name = name;
        Gender = gender;
        Sound = sound;
    }

    public void MakeSound()
    {
        Console.WriteLine($"Животное {Name} ({Gender}) издает: {Sound}");
    }
}