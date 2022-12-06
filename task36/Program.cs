// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] array = new int[5];

int res = 0;
for (int i = 0; i < 5; i++)
{
    int chislo = new Random().Next(-10, 10); // случайные числа от -10 до 10
    // int chislo = new Random().Next(); // случайные числа
    array[i] = chislo;
    if (((i % 2) == 1))
    {
        res += array[i];
        i++;
    }
}
Console.WriteLine($"Массив, заполенный случайнными числами - [{string.Join(",", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна - {res}");
