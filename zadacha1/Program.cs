// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    System.Console.Write($"Большее число = {number1} Меньшее число = {number2}");
}
else
{
    System.Console.Write($"Большее число = {number2} Меньшее число = {number1}");
}
