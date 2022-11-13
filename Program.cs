// Задача 10, Ввод 3-х значного числа и вывод цифры на второй позиции этого числа

/*
Console.WriteLine("Введите 3-х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
    a = a * -1;
while ((a / 100) < 1)
{
    Console.WriteLine("Число не 3-х значное, введите еще раз: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a < 0)
        a = a * -1;
}
Console.WriteLine(a/10%10);
*/



// Задача 13, Ввод числа и вывод 3 цифры этого числа, если такая имеется

/*
Console.WriteLine("Введите 3-х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
    a = a * -1;
if ((a / 100) < 1)
    Console.WriteLine("Третьей цифры нет");
else
{
    int i = 100;
    while (a / i > 10)
        i *= 10;
    Console.WriteLine(a * 100 / i % 10);
}
*/



// Задача 15, Ввод дня недели и вывод является ли этот день выходным

/*
Console.WriteLine("Введите День недели: ");
int day = Convert.ToInt32(Console.ReadLine());
while (day < 0 && day > 8)
{
    Console.WriteLine("Неверный день недели, введите снова: ");
    day = Convert.ToInt32(Console.ReadLine());
}
if (day > 5)
{
    Console.WriteLine(day + " - выходной день");
}
else
    Console.WriteLine(day + " - не выходной день");
*/
