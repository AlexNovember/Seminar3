// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// int Exponentiation(int numberA, int numberB)
// {
//   int result = 1;
//   for(int i=1; i <= numberB; i++)
//   {
//     result = result * numberA;
//   }
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine($"Степень {numberB} числа {numberA} = {exponentiation}"); 

// Без цикла
// Console.WriteLine("Ответ: " + Math.Pow(numberA, numberB));



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int number)
//   {
//     int count = Convert.ToString(number).Length;
//     int advance = 0;
//     int summa = 0;

//     for (int i = 0; i < count; i++)
//     {
//       advance = number - number % 10;
//       summa = summa + (number - advance);
//       number = number / 10;
//     }
//    return summa;
//   }

// int sumNumber = SumNumber(number);
// Console.WriteLine("Сумма цифр данного числа = " + sumNumber);




// // Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры. 
// Элементы тоже вводятся с клавиатуры.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите количество элементов массива: ");
        int ElementsCount = int.Parse(Console.ReadLine());
        int[] myArray = new int[ElementsCount];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите элемент массива под индексом ({i}): ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Вывод массива:");
        Console.Write("[");
        for (int i = 0; i < myArray.Length; i++)
        {
            if (i!=(ElementsCount-1))
              Console.Write($"{myArray[i]}, ");
            else 
              Console.Write($"{myArray[i]}");
        }
        Console.Write("]");
    }
}