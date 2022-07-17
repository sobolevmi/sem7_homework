// Задать двумерный массив из целых чисел. Найти среднее арифметическое элементов в каждом столбце
int [,] CreateNewArray (int rows, int columns, int start, int end)
{
    int [,] massive = new int [rows, columns];
    for (int i = 0; i < massive.GetLength (0); i++)
    {
        for (int j = 0; j < massive.GetLength (1); j++)
        {
            massive [i, j] = new Random().Next (start, end + 1);
        }
    }
    return massive;
}

void ShowArray (int [,] massiveNew)
{
    for (int index = 0; index < massiveNew.GetLength (0); index++)
    {
        for (int k = 0; k < massiveNew.GetLength (1); k++)
        {
            Console.Write (massiveNew [index, k] + "  ");
        }
        Console.WriteLine ();
    }
}

void AverageNumber (int [,] userArray)
{
    string temp = String.Empty;
    string result = temp;
    for (int p = 0; p < userArray.GetLength (1); p++)
    {
        double count = 0;
        double sumRow = 0;
        double average = 0;
        for (int l = 0; l < userArray.GetLength (0); l++)
        {
            sumRow = sumRow + userArray [l, p];
            count++;
        }
        average = sumRow / count;
        temp = Math.Round (average, 2) + "; ";
        result = result + temp;
    }
    Console.Write (result.Remove (result.Length - 2, 2));
}

Console.WriteLine ("Введите количество строк случайно генерируемого массива: ");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите количество столбцов случайно генерируемого массива: ");
int n = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите начальное число диапазона случайно генерируемых в массив чисел: ");
int startNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите конечное число диапазона случайно генерируемых в массив чисел: ");
int endNumber = Convert.ToInt32 (Console.ReadLine ());
int [,] array = CreateNewArray (m, n, startNumber, endNumber);
ShowArray (array);
Console.WriteLine ();
Console.Write ("Среднее арифметическое каждого столбца: ");
AverageNumber (array);