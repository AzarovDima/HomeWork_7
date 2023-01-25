/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
!!!ПРИМЕР!!!
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

int rows = GetNumbetFromUserM("Какое количество строк в массиве задашь? ", "Ошибка ввода! ");
int columns = GetNumbetFromUserN("А количество столбцов? ", "Ошибка ввода! ");
Console.WriteLine($"Генирирую массив заполненный случайными вещественными числами... ");
double[,] array = GetArray(rows, columns, -10, 10);

int GetNumbetFromUserN(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumberN);
        if (isCorrect)
            return userNumberN;
        Console.WriteLine(errorMessage);
    }
}
int GetNumbetFromUserM(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumberM);
        if (isCorrect)
            return userNumberM;
        Console.WriteLine(errorMessage);
    }
}

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(minValue + rnd.NextDouble() * (maxValue - minValue), 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
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
PrintArray(array);