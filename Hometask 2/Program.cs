/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.WriteLine("Введите первое число: ");
int numOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numTwo = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numThree = int.Parse(Console.ReadLine());
int max = numOne;
if (numOne<numTwo)
{
    max = numTwo;
    if (numTwo<numThree)
    max = numThree;
} else if (numOne<numThree)
max = numThree;
Console.WriteLine($"Наибольшее из трех чисел: {max}");
