/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

//int number = Int32.Parse(Console.ReadLine());
if (number > 1000 && number < 100)
{
    Console.WriteLine("wrong number");
return;
}    
int number2 = number / 10 % 10;  
Console.WriteLine(number2);