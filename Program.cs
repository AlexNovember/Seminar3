﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// try
//    { 
//     Console.Write("Введите пятизначное число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number.ToString().Length != 5)
//     Console.WriteLine("Введенное число не пятизначное! Введите пятизначное число!"); 
//     else if (number/1000==(number%10)*10+(number/10)%10)
//         Console.WriteLine("Это число палиндром");
//     else 
//         Console.WriteLine("Это число не палиндром.");
//     }
//     catch
// {
//     Console.WriteLine("Вы ввели не цифры!");
// }



// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)

// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }
// double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
// }

// double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2 );
// Console.WriteLine($"Расстояние между точками = {segmentLength}");




//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter < length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.WriteLine(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
