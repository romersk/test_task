using System;

class Task4
{
    public static void Main(string[] args)
    {
        int number = ReadInt();
        Console.WriteLine($"�� ����� �����: {number}");
    }

    static int ReadInt()
    {
        int number;
        while (true)
        {
            Console.WriteLine("������� �����:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("�������� ����. ����������, ������� �����.");
            }
        }
    }
}