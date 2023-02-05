// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
string Ferfero = GetCheckTheNumber(number);
Console.WriteLine(Ferfero);

string GetCheckTheNumber(int num)
{
    if (num > 9999 & num < 100000)
    {
        int ost1 = num % 10;
        int ost2 = (num / 10) % 10;
        int secondnum = (num / 1000) % 10;
        if (num / 10000 == ost1 & secondnum == ost2)
        {
            return "да";
        }
        else
        {
            return "нет";
        }
    }
    else
    {
        return "Прошу ввести 5-ти значное число";
    }
}