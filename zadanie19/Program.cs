//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
double X1, X2, Z1, Y1, Y2, Z2;

try
{
Console.Write("Введите первую координату! ");

X1 = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите вторую координату! ");
Y1 = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третью координату! ");
Z1 = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третью координату! ");
X2 = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третью координату! ");
Y2 = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третью координату! ");
Z2 = double.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибочка! Ведите число(Цифру! {exc.Message}");
    return;
}
double cor = DisPoint(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine($"{cor}");
static double DisPoint (double X1, double Y1, double Z1, double X2, double Y2, double Z2 )
{
    return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
}