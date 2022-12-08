// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

string Num(int num)
{
    if ((-1000 < num && num < -99) || (99 < num && num < 1000 ))
        return $"{num} -> {num / 100 * 10 + num % 10}";
    return "Номер не трехзначный!";
}
Console.WriteLine(Num(int.Parse(Console.ReadLine())));
