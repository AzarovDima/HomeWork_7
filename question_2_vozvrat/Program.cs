/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
 */

int number1 = GetNumberFromUser1("Введите номер строки массива: ", "Ошибка ввода попробуйте снова");
int number2 = GetNumberFromUser2("Введите номер столбца массива: ", "Ошибка ввода попробуйте снова");
int[,] array = GetArray(8, 6, 1, 100);
int GetNumberFromUser1(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int usernumber1);
        if (isCorrect)
            return usernumber1;
        else Console.WriteLine(errorMessage);
    }
}
int GetNumberFromUser2(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int usernumber2);
        if (isCorrect)
            return usernumber2;
        else Console.WriteLine(errorMessage);
    }
}
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return result;
}
Console.WriteLine("Получается массив... ");
PrintArray(array);
FindArray(array, number1, number2);
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindArray(int[,] firstArray, int number1, int number2)
{
    if (number1 < 0 || number1 > firstArray.GetLength(0) - 1 || number2 < 0 || number2 > firstArray.GetLength(1) - 1)
        Console.Write($"{number1}{number2} - > Такого числа нет в массиве!");
    else
        Console.Write($"Значение элемента массива -> {firstArray[number1, number2]}");
}
