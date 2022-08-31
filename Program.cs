// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse( s:Console.ReadLine());
Console.WriteLine("                       ");
bool a = true;
while (a == true)
{

    if(number > 99 && number < 1000)
    {
        Console.WriteLine($"{number} -> {number % 10} ");
        a = false;
    }
    else
    {
        a = false;
        Console.WriteLine("Это не трехзначное число");
        Console.WriteLine("Введите трехзначное число: ");
        int number1 = int.Parse( s:Console.ReadLine());
        if(number1 > 99 && number1 < 1000)
        {
        Console.WriteLine($"{number1} -> {number1 % 10} ");
        a = false;
        }
        else
        {

        }


    }
    
}
