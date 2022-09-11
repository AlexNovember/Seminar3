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


Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number)
  {
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int summa = 0;

    for (int i = 0; i < count; i++)
    {
      advance = number - number % 10;
      summa = summa + (number - advance);
      number = number / 10;
    }
   return summa;
  }

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр данного числа = " + sumNumber);




// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
// Console.Write("Введите ряд чисел, разделенных запятой : ");
// string? seriesOfNumbers = Console.ReadLine();

// seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// // функция удаления пробелов из строки 
// string RemovingSpaces (string series){
//   string seriesNew = "";
//   for (int i = 0; i < series.Length; i++)
//   {
//     if (series[i] != ' ') 
//     {
//       seriesNew += series[i];
//     }
//   }
//   return seriesNew;
// }

// //  функция  проверки на правильность ввода 
// void СheckNumber2 (int  series){

//       if (series == '0'||series == '1'||series == '2'
//       ||series == '3'||series == '4'||series == '5'||series == '6'
//       ||series == '7'||series == '8'||series == '9'||series == ','
//       ||series == '-')
//       {
//       }
//         else {
//           Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

//       }
// }

// // функция  создания и заполнения массива из строки
// int[] ArrayOfNumbers(string seriesNew){ 

//   int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

//   int j =0;

//   for (int i = 0; i < seriesNew.Length; i++){
//     string seriesNew1 = "";

//     while (seriesNew[i] != ',' && i < seriesNew.Length){
//       seriesNew1 += seriesNew[i];
//       СheckNumber2(seriesNew[i]);
//       i++;
//     }
//     arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
//     if (i < seriesNew.Length-1){
//       arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
//     }
//     j++;
//   }
//   return arrayOfNumbers;
// }

// // функция  вывода массива на печать 
// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   Console.Write("[");
//   while(index < count){
//     Console.Write(coll[index]);
//     index++;
//     if (index < count){
//       Console.Write(", ");
//     }
//   }
//   Console.Write("]");
// } 


// string seriesNew = RemovingSpaces(seriesOfNumbers);

// int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

// PrintArry(arrayOfNumbers);