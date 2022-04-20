int a = 896258, b = 0;
Console.Write($"Заданно число {a} -> ");
if (a > 100)
{
    while (a > 999) 
    {
        a = a/ 10;
    }
    b = a%10;
    Console.Write($"третья цифра в числе является {b}");
}
else
{
    Console.Write($"число {a} не трехзначное");
}