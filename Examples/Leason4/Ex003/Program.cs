//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void arr()
    {
        int[] array = new int[8];
        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 10);
            Console.Write("{0} ", array[i]);
       }
    }
    arr();