Console.WriteLine("Введите положительное число и я выведу все четные числа от 1 до Вашего числа:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine($"Чётные числа от 1 до {number}");

if (number == i || number == 0)
{
    Console.WriteLine($"в данном диапазоне нет четных чисел");
}
else if (number < 0)
{
    Console.WriteLine($"Ваше число должно быть больше 0");
}
else
{
    while (i < number)
    {
if (i % 2 != 1)
{
    Console.Write($"{i}, ");
}
var v = i++;
    }
}