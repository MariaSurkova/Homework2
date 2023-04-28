// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую 
//цифру этого числа.
int Prom(string msg)
{
System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int num = Prom("Введите трехзначное число");
if (num >=100 && num <1000)
{
int mid = (num % 100 - num % 10) / 10;
System.Console.WriteLine($"Вторая цифра числа {num} -> {mid}");
}
else
System.Console.WriteLine("Это число не трехзначное");

