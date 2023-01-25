/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
!!!ПРИМЕР!!!
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */


int numM = GetNumbetFromUser("Введите целоечисло m: ", "Ошибка ввода! ");

Console.WriteLine(numM);
int GetNumbetFromUser(string message, string errorMessage)
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