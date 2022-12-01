Console.WriteLine("Введите размер массива! ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
RandomNumbers(number);
PrintArray(number);
int count = 0;

for (int i = 0; i < number.Length; i++)
if (number[i] % 2 == 0)
count++;

Console.Write($" -> {count} колличество чётных");
Console.WriteLine();

void RandomNumbers(int[] number)
{
    for(int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(100,1000);
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