/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3->Среда 5->Пятница */

Console.WriteLine("Введите номер - ");

int number = int.Parse(Console.ReadLine());

if (number > 7)
{
    Console.WriteLine("F*ck u Tony, doesnt exist");
}
else if (number == 1)
{
    Console.WriteLine("It`s Monday");
}
else if (number == 2)
{
    Console.WriteLine("It`s Tuesday");
}
else if (number == 3)
{
    Console.WriteLine("It`s Wednesday");
}
else if (number == 4)
{
    Console.WriteLine("It`s Thursday");
}
else if (number == 5)
{
    Console.WriteLine("It`s Friday");
}
else if (number == 6)
{
    Console.WriteLine("It`s Saturday");
}
else if (number == 7)
{
    Console.WriteLine("It`s Sunday");
}