//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        array[i] = new Random().Next(0, 10);

    }
}


int Sum(int[] array)
{
    int len = array.Length;
    int result = 0;
    for (int i = 0; i < len; i = i + 2)
    {
        result = result + array[i];
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

int[] arr = CreateArray(6);
FillArray(arr);
PrintArray(arr);
int result = Sum(arr);
Console.WriteLine(result);
