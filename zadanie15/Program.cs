double number;

while(true)
{
    Console.Write("Введите число от 1 до 7! ");
    if(double.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Не правельный ввод! Введите число от 1 до 7!");
}
if(number < 6)
{
    Console.WriteLine($"{number} -> нет!");
}
else
{
    Console.WriteLine("Не правельный ввод! Введите число от 1 до 7!");
}
if(number == 6)
{
    Console.WriteLine($"{number} -> да!");
}
else if(number == 7)
{
    Console.WriteLine($"{number} -> да!");
}
