// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
RandomNumbers(arr);
void RandomNumbers(int[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
    Console.WriteLine(string.Join(", ", arr));
}
int count = 0;
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Колличество чисел больше 0: {count}");