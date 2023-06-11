// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99 && number < 1000)
{
    int result = number % 100 / 10;
    Console.WriteLine($"Вторая цифра трехзначного числа = {result}");
}
else
{
    Console.WriteLine("Ошибка! Введите трехзначное число!");
}
