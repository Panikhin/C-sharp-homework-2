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
    string result = number.ToString();
    Console.WriteLine($"Третья цифра числа = {result[2]}");
}