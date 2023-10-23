// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int FindSum(int nM, int nN)
{
  
    // выход из рекурсии
    if (nM >= nN)
        return 0;
    else
    {
        nM++;// увеличиваем на 1
        return nM + FindSum(nM, nN);
    }
}

int N = 0;
int M = 0;
Console.WriteLine("Программа ищет сумму натуральных элементов в промежутке от M до N\nВведите числа M и N:");
if (int.TryParse(Console.ReadLine(), out M) && (int.TryParse(Console.ReadLine(), out N)) && M > 0 && N > 0)
{
    Console.WriteLine($"Сумма чисел от {M} до {N} = {FindSum(M - 1, N)}");
}
else
{
    Console.WriteLine("Вы не ввели натуральные числа N и M!");
}


