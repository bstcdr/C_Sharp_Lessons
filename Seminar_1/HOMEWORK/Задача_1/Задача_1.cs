/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3
*/
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
<<<<<<< HEAD
<<<<<<< HEAD
else if (num1==num2)
{
    Console.WriteLine("числа равны");
}
else 
=======
=======
>>>>>>> main
else if (num1 == num2)
{
    Console.WriteLine("числа равны");
}
else
<<<<<<< HEAD
>>>>>>> 0497881 (Homework_3)
=======
>>>>>>> main
{
    Console.WriteLine("max = " + num2);
}