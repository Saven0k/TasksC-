// See https://aka.ms/new-console-template for more information
// . Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// Если честно то данную идея увидел у ребят и воплотил в более крутое  и красивое :)
Console.WriteLine("Введите день: ");
int day = int.Parse(Console.ReadLine());
string[] array = new string[] { "Понедельник" , "Вторник" , "Среда" , "Четверг" , "Пятница" , "Суббота" , "Воскресенье" };
if(day > 0 && day < 8)
{
    Console.WriteLine($"{day} день - {array[day-1]}");
}
else
{
    Console.WriteLine("Такого не существует");
}