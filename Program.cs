// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

try
   { 
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number.ToString().Length != 5)
    Console.WriteLine("Введенное число не пятизначное! Введите пятизначное число!"); 
    else if (number/1000==(number%10)*10+(number/10)%10)
        Console.WriteLine("Это число палиндром");
    else 
        Console.WriteLine("Это число не палиндром.");
    }
    catch
{
    Console.WriteLine("Вы ввели не цифры!");
}
