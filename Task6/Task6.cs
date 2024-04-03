using System;

class Program
{
    static void Main(string[] args)
    {
        Animal lion = new Animal("Лев", "мужской", "Рррррр");
        Animal elephant = new Animal("Слон", "женский", "Фрррр");
        Animal giraffe = new Animal("Жираф", "мужской", "Ням-ням");
        Animal monkey = new Animal("Обезьяна", "женский", "Уаааа");

        Enclosure lionEnclosure = new Enclosure("львы", 2, new Animal[] { lion });
        Enclosure elephantEnclosure = new Enclosure("слоны", 1, new Animal[] { elephant });
        Enclosure giraffeEnclosure = new Enclosure("жирафы", 3, new Animal[] { giraffe });
        Enclosure monkeyEnclosure = new Enclosure("обезьяны", 4, new Animal[] { monkey });

        int choice = 1;
        while (choice != 5)
        {
            Console.WriteLine("Что хотите посмотреть в зоопарке:");
            Console.WriteLine("1. Вольер с львами");
            Console.WriteLine("2. Вольер с слонами");
            Console.WriteLine("3. Вольер с жирафами");
            Console.WriteLine("4. Вольер с обезьянами");
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
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
        
    }
}