﻿Console.Write("Введите цифру от 1 до 7, соответствующую дню недели - ");
int a = int.Parse(Console.ReadLine());
if (a < 8 && a >0)
{
    if (a > 5)
    {
        Console.Write($"День {a} является выходным днем");
    }
    else
    {
        Console.Write($"День {a} не является выходным днем");
    }
}
else 
{
    Console.Write($"Вы ввели неправильные данные");
}