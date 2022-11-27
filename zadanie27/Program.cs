// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = GetInt("Введите число: ");
int length = LengthNumber(number);
SumNumbers(number, length);

/////////-------Ввод
int GetInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

////////---------Выевления цифр введенном числе
int LengthNumber(int a)
{
    int index = 0;
    while (a > 0) //каждая цифра в числе должна пройти условие истины, тоесть цифра из числа должа быть больше 0.
    {
        a /= 10; // деление на 10 выявляет длину цифр в этом числе
        index++; // Повторяем шаг с другой цифрой
    }
    return index;
}

///////-------- Cложения цифр в числе
void SumNumbers(int b, int length)
{
    Console.Write($"{number} -> ");
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += b % 10;
        b /= 10;
    }
    Console.WriteLine(sum);
}