// See https://aka.ms/new-console-template for more information
//5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1,2"
Console.WriteLine("Введите число");
int a = int.Parse( s :Console.ReadLine());
int b = a * (-1);
while (b<=a)
{
    Console.Write(b + " , ");
    b++;
}

// Данное решение ъоть и глупое но очень быстрое и удобное