using System;

class Task2 {
  public static void Main (string[] args) {
    string password = "Ts2jfpkwdd";
    string input;
    int count = 0;

    do {
      if (count > 0) {
        Console.WriteLine("Был введен неправильный пароль!");
      }
      count++;
      Console.WriteLine("Введите пароль: ");
      input = Console.ReadLine();
    } while (count < 3 || input != password);
    
    if (input == password) {
      Console.WriteLine("Тут должно быть секретное сообщение");
    } else {
      Console.WriteLine("Секретного сообщения не будет!\nВы превысели к-во попыток!");
    }
  }
}