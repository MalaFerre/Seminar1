//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
for (int i = 2; i <= number; i=i+2)
{
    System.Console.Write(i + " ");
}