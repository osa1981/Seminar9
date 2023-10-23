// функция Аккермана
// A(n, m) такая, что:
// A(0,m) = m+1
// A(n+1,0) = A(n,1)
// A(n+1, m+1) = A(n,A(n+1,m))

int Ack (int n, int m)
{

        // Поскольку для вычесления функции требуется очень большое число рекурсивных итераций, при n > 3 возможно переполнение буфера
        if (n > 3)
        {
            Console.WriteLine("Вы ввели слишком большое n (>3)!");
            return -1; // отрицательное значение сигнализирует об ошибке
        }
        while (n != 0)
        {
            if (m == 0)
                m = 1;
            else
            {
                m = Ack(n, m - 1);
            }

            n = n - 1;
        Console.Write("*"); //Нарисуем "индикатор" вычислений
        }

        return m + 1;
      
}

int nN = 0;
int nM = 0;

Console.WriteLine("Программа вычисляет значение функции Анкермана(N,M) для N <=3\nВведите N и M:");
if (int.TryParse(Console.ReadLine(), out nN) && (int.TryParse(Console.ReadLine(), out nM)))
{
    Console.WriteLine($"\nAckermann({nN},{nM}) result = {Ack(nN, nM)}");
}
else
    Console.WriteLine("Вы ввели неверные значения!");

