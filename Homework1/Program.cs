//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

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

string GetResult (int start, int end)
{
    if(start == end) return end.ToString();
    else return start + " " + GetResult(start +1, end);
}

int m=GetNumberFromUser($"Введите первое число ", "Ошибка ввода!"); 
int n=GetNumberFromUser($"Введите второе число ", "Ошибка ввода!"); 
string result = GetResult(m, n);
Console.Write(result);