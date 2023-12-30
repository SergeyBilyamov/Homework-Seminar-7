// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 101);
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void PrintArray(int[] num, int i = 0)
{
    if (i<num.Length)
    {
        Console.Write(num[i] + " ");
        PrintArray(num,i+1);
    }
}

void PrintReversArray(int[] list, int index)
{
    if (index >= 0)
    {
        Console.Write(list[index] + " ");
        PrintReversArray(list, index - 1);
    }
    
}


int size = GetNumberFromUser($"Введите размер массива ", "Ошибка ввода!");
int[] array = new int[size];

FillArray(array);
Console.WriteLine("исходный массив ");
PrintArray(array);
Console.WriteLine(" ");

Console.WriteLine("реверсивный массив ");
PrintReversArray(array, size-1);

