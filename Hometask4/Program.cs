/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = 2;
if (num < 2)
Console.WriteLine("Введите число побольше!");
else
{
    Console.WriteLine("Ваши числа: ");
    while (i<=num)
    {
        Console.WriteLine(i);
        i = i+2;
    }
}
