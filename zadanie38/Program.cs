//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
ArrayRandomNumbers(numbers);
PrintArray(numbers);
MinMaxRaznica(numbers);
Console.Write( " -> " + MinMaxRaznica(numbers));
Console.WriteLine();

double MinMaxRaznica(double[] numbers)
{
    double result = 0;
    int min = 0;
    int max = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[min] > numbers[i])
        min = i;
    else if (numbers[max] < numbers[i])
        max = i;
}
    
    if (numbers[min] > numbers[max])
        result = (numbers[min] - numbers[max]);
    else if (numbers[max] > numbers[min])
        result = (numbers[max] - numbers[min]);
    return result;
}
void ArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
}