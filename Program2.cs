// Задача 2.
// Программа принимает три числа и выдает наибольшее.

Console.Clear();

// Ввод трех чисел.

Console.WriteLine("Numbers compare.");

Console.Write("Enter first number: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int numberB = int.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int numberC = int.Parse(Console.ReadLine());

/*
    Сравнение чисел с присвоением переменной temporaryMax,
    Сравнение temporaryMax с numberC,
    Вывод данных.
*/
int temporaryMax = 0;
if (numberA > numberB)
{
    // YES!
    temporaryMax = numberA;
}
else
{
    // No!
    temporaryMax = numberB;
}
int Max = 0;
if (numberC > temporaryMax)
{
    // YES!
    Max = numberC;
    Console.WriteLine($"{numberA}, {numberB}, {numberC}, max = {Max}");
}
else
{
    // No!
    Max = temporaryMax;
    Console.WriteLine($"{numberA}, {numberB}, {numberC}, max = {Max}");
}