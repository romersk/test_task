using System;

class Program
{
    static void Main(string[] args)
    {
        Animal lion = new Animal("���", "�������", "������");
        Animal elephant = new Animal("����", "�������", "�����");
        Animal giraffe = new Animal("�����", "�������", "���-���");
        Animal monkey = new Animal("��������", "�������", "�����");

        Enclosure lionEnclosure = new Enclosure("����", 2, new Animal[] { lion });
        Enclosure elephantEnclosure = new Enclosure("�����", 1, new Animal[] { elephant });
        Enclosure giraffeEnclosure = new Enclosure("������", 3, new Animal[] { giraffe });
        Enclosure monkeyEnclosure = new Enclosure("��������", 4, new Animal[] { monkey });

        int choice = 1;
        while (choice != 5)
        {
            Console.WriteLine("��� ������ ���������� � ��������:");
            Console.WriteLine("1. ������ � ������");
            Console.WriteLine("2. ������ � �������");
            Console.WriteLine("3. ������ � ��������");
            Console.WriteLine("4. ������ � ����������");
            Console.WriteLine("5. ����� �� ��������");

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
                    Console.WriteLine("�������� �����.");
                    break;
            }
        }
        
    }
}