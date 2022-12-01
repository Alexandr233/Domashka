//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
RandomNumber(number);
PrintArray(number);
int sum = 0;

for (int i = 1; i < number.Length; i+=2)
    sum = sum + number[i];

    Console.WriteLine($" -> {sum}");
    Console.WriteLine();

void RandomNumber(int[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
}
