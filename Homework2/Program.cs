// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0)
    {
        return AckermanFunction(m - 1, 1);
    } 
    else
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}

int m = GetNumberFromUser($"Введите первое число ", "Ошибка ввода!");
int n = GetNumberFromUser($"Введите второе число ", "Ошибка ввода!");

Console.WriteLine(AckermanFunction(m,n));
