/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

// Генерация массива вещественных чисел от 0 до 100
double[] GenerateDoubleArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

// Вывод массива в строку
void PrintArray(double[] array)
{
    System.Console.Write("[" + Math.Round(array[0], 3));
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(" " + Math.Round(array[i], 3));
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

// Разность max - min с точностью до 3 знаков после запятой
double DifferenceOfMinMax(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    System.Console.WriteLine("Максимальный элемент массива: " + Math.Round(max, 3));
    System.Console.WriteLine("Минимальный элемент массива: " + Math.Round(min, 3));
    return diff;
}

System.Console.WriteLine("Введите длину массива: ");
double[] array = GenerateDoubleArray(int.Parse(Console.ReadLine()));

PrintArray(array);

System.Console.WriteLine($"Разность между максимальным и минимальным элементом массива равна: {Math.Round(DifferenceOfMinMax(array), 3)}");