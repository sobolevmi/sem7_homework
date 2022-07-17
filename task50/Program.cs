// Программа, которая принимает на вход позиции элемента в двумерном массиве и возвращает его значение либо указывает, что такого элемента нет
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
    Console.WriteLine ();
}

void FindElement (int [,] userArray, int index1, int index2)
{
    bool result = false;
    for (int l = 0; l < userArray.GetLength (0); l++)
    {
        for (int p = 0; p < userArray.GetLength (1); p++)
        {
            if ((l == index1) && (p == index2))
            {
                Console.Write ($"[{index1},{index2}] -> {userArray [l, p]}");
                result = true;
            }
        }
    }
    if (result == false)
    {
    Console.Write ($"[{index1}, {index2}] -> такого числа в массиве нет");
    }
}

Console.WriteLine ("Введите количество строк случайно генерируемого массива: ");
int m = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите количество столбцов случайно генерируемого массива: ");
int n = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите начальное число диапазона случайно генерируемых в массив чисел: ");
int startNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите конечное число диапазона случайно генерируемых в массив чисел: ");
int endNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ();
int [,] array = CreateNewArray (m, n, startNumber, endNumber);
ShowArray (array);
Console.WriteLine ("Введите первый индекс (номер строки) числа, которое вы хотите найти в массиве: ");
int userIndex1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второй индекс (номер столбца) числа, которое вы хотите найти в массиве: ");
int userIndex2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ();
Console.WriteLine ("-------------------");
FindElement (array, userIndex1, userIndex2);