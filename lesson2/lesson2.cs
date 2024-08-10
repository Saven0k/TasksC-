/**
Задача 9
Напишите программу,которая выводит случайное число из отрезка [10 , 99] и показывает наибольшую цифру числа.
    78 -> 8 
    12 -> 2
    85 -> 8

*/
int rnd =  new Random().Next(10,100);
int des = rnd / 10;
int des2 = rnd % 10;
int max = des;
if(des2>max) max = des2;
Console.WriteLine($"Максимальное в {rnd} -> {max}");