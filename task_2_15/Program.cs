// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear();
Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
        Console.WriteLine("Это понедельник. Не выходной");
        break;
    case 2:
        Console.WriteLine("Это вторник. Не выходной");
        break;
    case 3:
        Console.WriteLine("Это среда. Не выходной");
        break;
    case 4:
        Console.WriteLine("Это четверг. Не выходной");
        break;
    case 5:
        Console.WriteLine("Это пятница. Не выходной");
        break;
    case 6:
        Console.WriteLine("Это суббота. Да выходной");
        break;
    case 7:
        Console.WriteLine("Это воскресенье. Да выходной");
        break;
    default:
        Console.WriteLine("Ошибка! Введите цифру от 1 до 7");
        break;
}