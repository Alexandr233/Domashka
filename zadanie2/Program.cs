Console.WriteLine("Какое число больше из двух чисел?");

Console.WriteLine("Введите первое число и нажмите Enter ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе  число и нажмите Enter ");
int numB = int.Parse(Console.ReadLine());

if(numA > numB)
{
    Console.WriteLine($"max = {numA}");
}
else
{
    Console.WriteLine($"max = {numB}");
}
