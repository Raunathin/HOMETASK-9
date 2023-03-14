// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) 
//этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();

System.Console.WriteLine("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"НОД {a} и {b} равен {GetNOD(a, b)}");


int GetNOD(int n, int m)
{
    if (m == 0) return n;
    return GetNOD(m, n % m);
}










