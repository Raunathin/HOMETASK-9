/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

System.Console.WriteLine("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма чисел от {a} до {b} равно {GetSummNum(a, b)}");



int GetSummNum (int m, int n)
{
    if (m == n) return n;
   return m + GetSummNum(m + 1, n);
}








