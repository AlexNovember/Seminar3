// void Main()
//         {
            // int size = 20;
            int[] array = new int[8];
            // Random myRandom = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 8);
                if (i!=7) Console.Write($"{array[i]}, ");
                Console.Write($"{array[i]}");
            }
 
        