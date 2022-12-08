// Напишите программу, которая принимает на вход 
// трехзначное число и на выходе показывает вторую цифру 
// этого числа.

string NumA(int num)
{
    if ((-1000 < num && num < -99) || (99 < num && num < 1000 ))
        return $"{num / 10 % 10}";
    return "Номер не трехзначный!";
}       
Console.WriteLine(NumA(int.Parse(Console.ReadLine())));