/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8
*/

Console.Clear();

System.Console.WriteLine("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число M: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Числа от {a} до {b}");

FindNumbers(a, b);

void FindNumbers(int n, int max)
{
    if (n > max) return;
    if (n % 2 == 0)
    { 
        System.Console.Write($"{n} "); 
    }
    FindNumbers(n + 1, max);

}







