Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("У тебя ДР");
Console.WriteLine("И ты собераешься полететь в отпуск с твоими друзьями");
Console.WriteLine("А праграмма помодет посчитать по сколько надо тебе скидываться");
Console.WriteLine("Выбери куда ты хочешь полететь");
Console.WriteLine("1 - Испания, 2 - Италия, 3 - Франция");
switch(int)
{
    case 1:
        Console.WriteLine("Ты решил полететь в Испанию");
        Console.WriteLine("Билет(ы) стоит 100 бунов");
        Console.WriteLine("Введите сколько вас летит");
        int friends = int.Parse(Console.ReadLine());
        Console.WriteLine($"ВЫ должны скинуться по {100 / friends}бунов");
        break;
    case 2:

        break;
}
