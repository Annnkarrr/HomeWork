//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int max = 0;

if (number > max)
{
    max = number;
}
if (number1 > max)
{
    max = number1;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($" Максимальное число = {max}");

