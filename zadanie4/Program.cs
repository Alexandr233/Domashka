int numA;
int numB;
int numC;
int max;

Console.WriteLine("Какое число больше из трёх чисел?");

Console.Write("Введите первое число и нажмите Enter ");
numA = int.Parse(Console.ReadLine());

Console.Write("Введите второе  число и нажмите Enter ");
numB = int.Parse(Console.ReadLine());

Console.Write("Введите третье число и нажмите Enter ");
numC = int.Parse(Console.ReadLine());
max = numA;
if(max < numB)
{
    max = numB;
}

if(max < numC) 
{
    max = numC;
}
Console.WriteLine($"max = {max}");
//Console.WriteLine(Math.Max(numA, Math.Max(numB, numC)));
//Это второе решение, которое я подсмотрел из гугла.Команда Math.Max(a,b) - из двух переменных выводит максимум.
//В данном случае у нас было 3 числа вводных, поэтому были задействованы скобки ведь из математике первое действие в скобках выполняеться.
//Тоесть Math.Max(numA, Math.Max(numB, numC)) сначала сравиниваеться numB и numC, к примеру numB оказался больше и он сравниваеться с numA.
//Затем выводиться результат.
