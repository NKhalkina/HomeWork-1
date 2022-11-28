/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/


Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA%2;

if (numberB == 0)
{
    Console.WriteLine("Чётное");
}
else {
    Console.WriteLine("Нечётное");
}