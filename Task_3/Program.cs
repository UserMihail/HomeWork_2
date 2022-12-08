// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

void NumB(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
    {
        Console.WriteLine("there is no digit");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

NumB(int.Parse(Console.ReadLine()));