//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Все четные числа: ");

for (int count = 2; count <= N; count+=2)
{
    Console.WriteLine(count);
}
