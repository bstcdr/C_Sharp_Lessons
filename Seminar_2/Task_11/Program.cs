// 11. Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

Random rndm = new Random();
int randomNumber = rndm.Next(100, 1000);
Console.WriteLine("Случайное число - " + randomNumber);

int firstDigit = randomNumber / 100;
int ost = randomNumber % 10;
int newNumber = firstDigit * 10 + ost;

Console.WriteLine("Ответ: " + newNumber);

