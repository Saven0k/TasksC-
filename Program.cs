// See https://aka.ms/new-console-template for more information
// 
Console.WriteLine("Введите день: ");
int day = int.Parse(Console.ReadLine());
List<string> title_day_in_week = new List<string>() { "Понедельник", "Вторник", "Cреда" , "Четверг"  , "Пятница"  ,"Суббота"  ," Воскресенье"  };
if(day == 1)
{
     Console.WriteLine(title_day_in_week[0]);
}
else if(day == 2)
{
    Console.WriteLine(title_day_in_week[1]);
}
else if(day == 3)
{
    Console.WriteLine(title_day_in_week[2]);
}
else if(day == 4)
{
    Console.WriteLine(title_day_in_week[3]);
}
else if(day == 5)
{
    Console.WriteLine(title_day_in_week[4]);
}
else if(day == 6)
{
    Console.WriteLine(title_day_in_week[5]);
}
else if(day == 7)
{
    Console.WriteLine(title_day_in_week[6]);
}
else
{
    Console.WriteLine("Такого дня не существует");
}


