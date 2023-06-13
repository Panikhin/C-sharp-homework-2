// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100)
{
    Console.WriteLine("Ошибка! В числе третьей цифры нет!");
}
else
{
    if (number < 1000)
    {
        Console.WriteLine(number % 10);
    }
    else
    {
        while (number > 999)
        {
        number = number / 10;
        }
        Console.WriteLine(number % 10);
    }
}
