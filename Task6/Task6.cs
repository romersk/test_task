using System;

class Task6
{
    public static void Main(string[] args)
    {
        Animal lion = new Animal("лев Рык", "мужской", "рррр");
        Animal lionTwo = new Animal("лев Туш", "мужской", "рррр");
        Animal elephant = new Animal("слон", "мужской", "фррр");
        Animal giraffe = new Animal("жираф Олли", "женский", "ням-ням");
        Animal giraffeTwo = new Animal("жираф Раф", "мужской", "ням-ням");
        Animal giraffeThree = new Animal("жираф Рон", "мужской", "ням-ням");
        Animal monkey = new Animal("обезьяна Нола", "женский", "уа-уаа");
        Animal monkeyTwo = new Animal("обезьяна Крык", "мужской", "уа-уаа");

        Enclosure lionEnclosure = new Enclosure("львы", 2, new Animal[] { lion, lionTwo });
        Enclosure elephantEnclosure = new Enclosure("слоны", 1, new Animal[] { elephant });
        Enclosure giraffeEnclosure = new Enclosure("жирафы", 3, new Animal[] { giraffe, giraffeTwo, giraffeThree});
        Enclosure monkeyEnclosure = new Enclosure("обезьяны", 2, new Animal[] { monkey, monkeyTwo });

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
