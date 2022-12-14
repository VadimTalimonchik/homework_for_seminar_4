// Задача 25.
// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число А: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int n = int.Parse(Console.ReadLine()!);

// double extent = Math.Pow(A, B);

// Console.WriteLine($"Число {A} возведённое в степень {B} будет равно: {extent}.");


Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень B: ");
int n = int.Parse(Console.ReadLine()!);

int extent = 1;
for(int i = 0; i < n; i++)
{
    extent *= a;
}

Console.WriteLine($"Число {a} возведённое в степень {n} будет равно: {extent}");