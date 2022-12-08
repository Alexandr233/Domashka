//Задание 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце...
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3



Console.Clear();
int[,] creatMatrRndInt = CreateMatrRndInt(3, 4, 1, 9);
PrintMatrix(creatMatrRndInt);
ArithMean(creatMatrRndInt);

int[,] CreateMatrRndInt(int rows, int colum, int min, int max)
{
    int[,] matr = new int[rows, colum];
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

void ArithMean(int[,] matr)
{
    Console.Write("Среднее арифметическое каждого столбца: -> ");
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double summaArithmetic = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
           summaArithmetic += matr[i, j];
        }
double resultMathRound = Math.Round(summaArithmetic / matr.GetLength(0), 2);
Console.Write($"{resultMathRound} ");
    }
}