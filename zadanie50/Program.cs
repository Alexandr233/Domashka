//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание,
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] createMatrRndInt = MatrRndInt(5, 7, 1, 10);
PrintMatrix(createMatrRndInt);
Elementmatr(createMatrRndInt);

int[,] MatrRndInt(int rows, int col, int min, int max)
{
    int[,] matr = new int[rows, col];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void Elementmatr(int[,] matr)
{
    if (row < matr.GetLength(0) && col < matr.GetLength(1))
        Console.WriteLine($"Такое число есть в массиве -> {matr[row, col]}");
    else
        Console.WriteLine($"{row}, {col} -> Такого числа в массиве нету!");
}

