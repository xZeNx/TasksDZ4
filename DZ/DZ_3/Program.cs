// Напишите программу, которая задаёт массив из N элементов и
// выводит их на экран.

Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] numbers=new int[number];
void FillArray(int[] array)
{
    for(int i =0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(0,101);
    }
}
void PrintArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
Console.WriteLine("Вывод: ");
FillArray(numbers);
PrintArray(numbers);
