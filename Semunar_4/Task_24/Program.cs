using Common;

int number = SystemCoordinate.GetNumberFromUser();


int sum = GetSumNumberBetweenOneToNumber(number);
Console.WriteLine(sum);

int GetSumNumberBetweenOneToNumber(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

