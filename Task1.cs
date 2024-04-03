using System;

class Task1 {
  public static void Main (string[] args) {
    Console.Write("Введите кол-во старушек: ");
    int count = int.Parse(Console.ReadLine());

    int timeOfQueue = count * 10;
    Console.WriteLine($"Вы должны отстоять в очереди {timeOfQueue/60} часа и {timeOfQueue%60} минут");
  }
}