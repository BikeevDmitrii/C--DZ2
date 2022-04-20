Random a = new Random();
int b = a.Next(100, 999), c = 0, d = 0;
c = b%10; 
d = b / 100;
Console.WriteLine($"Случайное число {b}, удаляем вторую цифру в этом числе и получаем число {d}{c}"); 