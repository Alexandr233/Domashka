int[] array = new int[8];

FillAray(array);
PrintArray(array);
///Заполнение массива
void FillAray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}
///Вывод массива
void PrintArray (int[] array)
{
    Console.Write($"[ ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
    Console.Write($"]");
}