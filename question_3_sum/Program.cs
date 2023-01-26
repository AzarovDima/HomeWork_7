/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

int rows = GetRows("Задайте количество строк массива: ", " Ошибка ввода попробуйте снова!!! ");
int colums = GetColums("Выберите количество столбцов в массиве: ", "Вы запутались в цыфрах! Попробуйте еще раз! ");



int GetRows(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number1);
        if (isCorrect)
            return number1;
        Console.WriteLine(errorMessage);
    }
}
int GetColums(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number2);
        if (isCorrect)
            return number2;
        Console.WriteLine(errorMessage);
    }
}
int[,] array = NewArray(rows, colums, 1, 8);



Console.WriteLine("Печатаю массив... ");
PrintArray(array);
Console.WriteLine("Среднее арифметическое элементов каждого столбца показано ниже:");
MiddleColums(array);
int[,] NewArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

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

void MiddleColums(int[,] inArray)
{

    //double middle = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double middle = 0;
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
            middle = Math.Round(sum / inArray.GetLength(0), 1);

        }

        Console.Write($"{middle} ");
    }
}















