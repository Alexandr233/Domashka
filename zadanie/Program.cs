
Console.WriteLine("Введите трехзначное число! ");
int a = int.Parse(Console.ReadLine());
if(a > 100 && a < 1000)
{
    Console.Write($"{a} -> ");
}
else 
{
    Console.WriteLine("Не правильный ввод! Ведите трехзначное число! ");
}

int b = a % 100 / 10;

Console.Write($"{b}");