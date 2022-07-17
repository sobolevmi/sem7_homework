// Создать двумерный массив размерами m на n, заполненный случайными вещественными числами
double [,] CreateNewArray (int rows, int columns, int start, int end)
{
    double [,] massive = new double [rows, columns];
    Random rand = new Random ();
    for (int i = 0; i < massive.GetLength (0); i++)
    {
        for (int index = 0; index < massive.GetLength (1); index++)
        {
            massive [i, index] = rand.Next (start, end + 1) + rand.NextDouble ();
        }
    }
    return massive;
}

void ShowArray (double [,] massiveNew)
{
    for (int i = 0; i < massiveNew.GetLength (0); i++)
    {
        for (int j = 0; j < massiveNew.GetLength (1); j++)
        {
            Console.Write (Math.Round (massiveNew [i, j], 1) + "  ");
        }
        Console.WriteLine ();
    }
}

Console.WriteLine ("Введите количество строк (m) случайно генерируемого массива: ");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите количество столбцов (n) случайно генерируемого массива: ");
int n = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите начальное число диапазона случайно генерируемых в массив чисел: ");
int startNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите конечное число диапазона случайно генерируемых в массив чисел: ");
int endNumber = Convert.ToInt32 (Console.ReadLine ());
double [,] array = CreateNewArray (m, n, startNumber, endNumber);
Console.WriteLine ($"m = {m}, n = {n}.");
ShowArray (array);