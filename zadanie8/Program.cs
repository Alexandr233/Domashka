﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//Задаем int ,чтобы в коде его не писать.
int n;
int i;
//Просим пользователя ввести число.
Console.Write("Введите число ");
//Преобразуем полученное число.
n = Convert.ToInt32(Console.ReadLine());

//Далее цикл i = 1 - тоесть начало цикла начинаеться с 1. 
//i < n - пока i не будет равен или больше n цикл не закончиться.
//i++ - это шаг(возвращение к началу цикла только со следующим значением), как index = index + 1
for (i = 1; i <= n; i++) 
{
    if((i % 2) == 0)  
    {
        Console.WriteLine(i);    
    }

}
