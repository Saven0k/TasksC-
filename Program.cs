// See https://aka.ms/new-console-template for more information
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите первое число  : ");
int number1 = int.Parse( s :Console.ReadLine());
Console.WriteLine("Введите второе число  : ");
int number2 = int.Parse( s :Console.ReadLine());
Console.WriteLine("Введите третие число  : ");
int number3 = int.Parse( s :Console.ReadLine());

if(number1>number2) 
{
        Console.WriteLine($"Число {number1} самое большое ");
        if(number1>number3)
        {

                Console.WriteLine($"Число {number1} самое большое ");

        }
        else
        {


            Console.WriteLine($"Число {number3} самое большое");
        }

}
else

{

        
        if(number2>number3)
        {

            Console.WriteLine($"Число {number2} самое большое ");

        }

        else
        {

            Console.WriteLine($"Число {number3} Самое большое число");
        }
}



