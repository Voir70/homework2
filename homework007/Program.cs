﻿/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("\n Введите номер дня недели  ");
int num = int.Parse(Console.ReadLine());
if (num >= 1 && num <= 5)
{
    Console.WriteLine(" Нет, это рабочий день");
}

else if (num >= 6 && num <= 7)
{
    Console.WriteLine(" Да, это выходной");
}
else Console.WriteLine(" Не существует такого дня недели");
