/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

// Сумма элементов на нечетных позициях
int SummOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

System.Console.WriteLine("Введите длину массива: ");
int[] array = GenerateArray(int.Parse(Console.ReadLine()), -100, 101);
PrintArray(array);

System.Console.WriteLine($"Сумма элеменов массива на нечетных позициях равна: {SummOddPosition(array)}");