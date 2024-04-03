using System;

class Program
{
    static void Main(string[] args)
    {
        Animal lion = new Animal("лев", "мужской", "рррр");
        Animal elephant = new Animal("слон", "мужской", "фррр");
        Animal giraffe = new Animal("жираф", "женский", "ням-ням");
        Animal monkey = new Animal("обезьяна", "женский", "уа-уаа");

        Enclosure lionEnclosure = new Enclosure("львы", 2, new Animal[] { lion });
        Enclosure elephantEnclosure = new Enclosure("слоны", 1, new Animal[] { elephant });
        Enclosure giraffeEnclosure = new Enclosure("жирафы", 3, new Animal[] { giraffe });
        Enclosure monkeyEnclosure = new Enclosure("обезьяны", 4, new Animal[] { monkey });

        int choice = 1;
        while (choice != 5)
        {
            Console.WriteLine("Выбери действия в зоопарке:");
            Console.WriteLine("1. Посмотреть вольер львов");
            Console.WriteLine("2. Посмоотреть вольер слонов");
            Console.WriteLine("3. Посмотреть вольер жирафов");
            Console.WriteLine("4. Посмотреть вольер обезьян");
            Console.WriteLine("5. Выйти из зоопарка");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    lionEnclosure.ApproachEnclosure();
                    break;
                case 2:
                    elephantEnclosure.ApproachEnclosure();
                    break;
                case 3:
                    giraffeEnclosure.ApproachEnclosure();
                    break;
                case 4:
                    monkeyEnclosure.ApproachEnclosure();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Такого пункта нет. Выбери еще раз");
                    break;
            }
        }
        
    }
}
