// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = GetInt("Введите число A: ");
int B = GetInt("Введите число B: ");
DoubleDegree(A, B);


//--- Ввода
int GetInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//----Возведения в степень
void DoubleDegree(int a, int b)
{
    Console.Write($"{A}, {B} -> ");
    int с = 1;
    for (int i = 1; i <= b; i++)
    {
        с = с * a;
    }
    Console.Write(с);
}