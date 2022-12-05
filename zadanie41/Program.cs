//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine("Введите количество элементов: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] array = PrintNumbers(numbers);
Console.WriteLine($"Чисел больше нуля -> {NumberElements(array)}");

int[] PrintNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число {i} -> ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int NumberElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}