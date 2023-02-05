// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Не использовать string[]
// 645-> 5
// 78->третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num > 99) {
 while (num > 999)
 {
        num = num / 10;
    }
    int otv = num % 10;
    Console.Write("-> " + otv);
}
else {
    Console.Write("Нет третьего числа");
}
