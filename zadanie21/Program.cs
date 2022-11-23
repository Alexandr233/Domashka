//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
string num;

Console.Write("Введите пятизначное число! ");
num = Console.ReadLine() ?? "";
//}
//catch(Exception exc)
//{
//    Console.WriteLine($"Не правильно введен ввод! Введите число(цифры) {exc.Message}!");
//    return;
//}
int p = num.Length;

if (p == 5)
{
    if (num[0] == num[4])
    {
        Console.WriteLine($"{num} -> Да!");
    }
    else
    {
        Console.WriteLine($"{num} -> Нет!");
    }
}
else
{
       Console.WriteLine($"Не верно! Ошибка! {num} - Введите пятизначное число! ");
}


