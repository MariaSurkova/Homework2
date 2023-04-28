// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую 
// //цифру этого числа.
// int Prom(string msg)
// {
// System.Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int num = Prom("Введите трехзначное число");
// if (num >=100 && num <1000)
// {
// int mid = (num % 100 - num % 10) / 10;
// System.Console.WriteLine($"Вторая цифра числа {num} -> {mid}");
// }
// else
// System.Console.WriteLine("Это число не трехзначное");

// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

// int Prog(string msg)
// {

// System.Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int num = Prog("Введите число");

// int fnum(int num)
// {
// while (num > 999)
// {
// num /= 10;
// }
// return num % 10;
// }

// bool check(int number)
// {
// if (num < 100)
// return false;
// else return true;
// }

// if (check(num) != true)
// System.Console.WriteLine("Третьей цифры нет");
// else
// System.Console.WriteLine($"Третья цифра числа {num} -> {fnum(num)}");

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
string week (int num)
{
    if (num < 1) Console.WriteLine ("Введите корректый день недели от 1 до 7");
    if (num > 7) Console.WriteLine ("Введите корректый день недели от 1 до 7");
    if (num > 5) Console.WriteLine ("Сегодня выходной");
    if (num >= 1 & num < 5) Console.WriteLine ("Сегодня рабочий день");
    return ("0");
}
Console.WriteLine ("Введите день недели");
int num = Convert.ToInt32(Console.ReadLine());
week(num);