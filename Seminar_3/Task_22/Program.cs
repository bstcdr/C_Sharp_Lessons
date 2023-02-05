// Задача No22.Работа в группах
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] arr = GetCalculateTheSquare(number);
PrintArray(arr);

int[] GetCalculateTheSquare(int N)
{
    int[] array = new int[N];

    for (int i = 0; i < N; i++)
    {
        array[i] = (i + 1) * (i + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}









