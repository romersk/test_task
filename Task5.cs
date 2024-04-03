using System;
using System.Collections.Generic;

class Task5
{
    public static void Main(string[] args)
    {
        Queue<int> purchases = new Queue<int>();
        int totalMoney = 0;

        purchases.Enqueue(75);
        purchases.Enqueue(24);
        purchases.Enqueue(36555);
        purchases.Enqueue(1);

        while (purchases.Count > 0)
        {
            totalMoney += purchases.Dequeue();
            Console.WriteLine($"Общая сумма денег на счету: {totalMoney}");
        }

        Console.WriteLine("Очередь закончилась.");
    }
}