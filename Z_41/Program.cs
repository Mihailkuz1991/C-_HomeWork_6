/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int Count = getUserData("Введите размер массива");

int[] array = new int[Count];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    array[i] = int.Parse(Console.ReadLine()!);
}

int FindPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result = result + 1;
        }
    }
    return result;
}

int[] printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    return array;
}

int[] PrintResult = printArray(array);
int PositiveNumbers = FindPositiveNumbers(array);
Console.WriteLine($"{PrintResult} --> {PositiveNumbers} ");


