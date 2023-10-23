// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void PrintNaturalto1(int nN)
{
    
    // Выход из рекурсии - когда дойдем до 1
    if (nN < 1)
        return;
    else
    {
        Console.Write($"{nN}\t");
        PrintNaturalto1(nN - 1); // шаг рекурсии - уменьшаем на 1
        
    }
}

int nNum = 0;
Console.WriteLine("Программа выводит все натуральные числа в промежутке от N до 1\nВведите натуральное число N:");
try
{
    // Проверим, что ввели натуральное число, а не мусор
    if(int.TryParse(Console.ReadLine(), out nNum) && nNum >0)
        PrintNaturalto1(nNum);
    else
        Console.WriteLine("Вы не ввели натуральное число!");
}
catch
{
    Console.WriteLine("Внутренняя ошибка программы!");
}
