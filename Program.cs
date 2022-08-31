// See https://aka.ms/new-console-template for more information
// Напишите программу , которая будет принимать на вход 2 числа, и проверять не являеться ли одно квадратом другого
Console.WriteLine("Введите  первое число: ");
int sqr = int.Parse( s :Console.ReadLine());
Console.WriteLine("Введите  второе число: ");
int number = int.Parse( s :Console.ReadLine());

int result = number * number;

if(result == sqr)
{
    Console.WriteLine($"Число  {sqr} являеться квадратом числа {number}");
}
else
{
    Console.WriteLine($"Число {sqr} не являеться квадратом числа {number}");
}







