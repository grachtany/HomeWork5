// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double Max(double arg1, double arg2, double arg3, double arg4, double arg5)
{
    double result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    if (arg4 > result) result = arg4;
    if (arg5 > result) result = arg5;

    return result;
}
double Min(double arg1, double arg2, double arg3, double arg4, double arg5)
{
    double result = arg1;
    if (arg2 < result) result = arg2;
    if (arg3 < result) result = arg3;
    if (arg4 < result) result = arg4;
    if (arg5 < result) result = arg5;

    return result;
}
double[] array = { 3, 22, 89, 2, 78, 7 };

double max = Max(array[0], array[2], array[3], array[4], array[1]);
double min = Min(array[0], array[2], array[3], array[4], array[1]);
double raz = max - min;
Console.WriteLine($"[{string.Join(" ", array)}] -> {raz}");