/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double b1 = getUserData("Введите k1: ");
double k1 = getUserData("Введите k1: ");
double b2 = getUserData("Введите b2: ");
double k2 = getUserData("Введите k2: ");
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

System.Console.WriteLine($"Пересечение прямых в точке: ({x};{y})");