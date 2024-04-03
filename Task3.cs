using System;

class Task3 {
  public static void Main (string[] args) {
    Random random = new Random();
    int[,] array = new int[10,10];
    int max = array[0, 0];
    int iMax = 0;
    int jMax = 0;
    
    for (int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++) {
        array[i, j] = random.Next(50);

        Console.Write($"{array[i, j]} ");

        if (max < array[i, j]) {
          max = array[i, j];
          iMax = i;
          jMax = j;
        }
      }
      Console.WriteLine();
    }

    Console.WriteLine($"Max element is {array[iMax, jMax]}\n");
    array[iMax, jMax] = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++) {
        Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
    }
  }
}