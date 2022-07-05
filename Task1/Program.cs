/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

// Генерация массива
int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Вывод массива в строку
void PrintArray(int[] array)
{
    System.Console.Write("[" + array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

// Количество четных чисел в массиве
int NumberOfEven2(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] %2 == 0) count++;
}
return count;
}

System.Console.WriteLine("Введите длину массива: ");
int[] array = GenerateArray(int.Parse(Console.ReadLine()), 100, 1000);
PrintArray(array);

System.Console.WriteLine($"Количество четных чисел в массиве равно: {NumberOfEven2(array)}");