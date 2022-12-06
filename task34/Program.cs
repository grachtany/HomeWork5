// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 397, 563, 234] -> 2
Console.Clear();
int[] array = new int[3];

int j = 0;
for (int i = 0; i < 3; i++)
{
    int rnd = new Random().Next(100, 1000);
    array[i] = rnd;
    if ((array[i] % 2) == 0) j++;
}
Console.WriteLine($"Количество четных чисел в массиве [{string.Join(",", array)}] - {j}");

// Еще один вариант решения. 

// int i = 0;
// while (i < 3)
// {
//     int rnd = new Random().Next(1, 100);
//     array[i] = rnd;
//     i++;
// }
// // Console.WriteLine ($"[{string.Join(",", array)}]");

// i = 0;
// int j = 0;
// while (i < 3)
// {
//     if ((array[i] % 2) == 0) j++;
//     i++;
// }
// Console.WriteLine($"Количество четных чисел в массиве [{string.Join(",", array)}] - {j}");


