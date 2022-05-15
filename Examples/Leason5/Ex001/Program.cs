//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int count)
{
    int[] result = new int[count];
    return result;
}

void FillArray(int[] array)
{
    int len = array.Length;

    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(100, 1000);

    }
}


int Sum(int[] array)
{
    int len = array.Length;
    int result = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



int[] arr = CreateArray(7);
FillArray(arr);
PrintArray(arr);
int result = Sum(arr);
Console.WriteLine(result);

