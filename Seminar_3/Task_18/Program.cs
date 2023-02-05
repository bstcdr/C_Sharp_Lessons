
Console.Write("Введите номер четверти: ");
int quarterNumber = int.Parse(Console.ReadLine());
string result = GetDiapazon(quarterNumber);
Console.WriteLine(result);

string GetDiapazon (int numberOfQuarter)
{
    if (numberOfQuarter == 1)
    {
        return "x > 0 и y > 0";
    }
    if (numberOfQuarter == 2)
    {
        return "x < 0 и y > 0";
    }
    if (numberOfQuarter == 3)
    {
        return "x < 0 и y < 0";
    }
    if (numberOfQuarter == 4)
    {
        return "x > 0 и y < 0";
    }
    else 
    {
        return "1, 2, 3, 4 только";
    }
}