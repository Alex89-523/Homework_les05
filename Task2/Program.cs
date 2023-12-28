// Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива.
// Пример
// 4 3 1 => 4 6 2 
// 2 6 9    2 6 9
// 4 6 2    4 3 1

int[,] Create2DArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] Replacement(int[,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[3, i];
        array[3, i] = array[0, i];
        array[0, i] = tmp;
    }
    return array;
}

int[,] myArray = Create2DArray(4,4,0,9);
Print2DArray(myArray);
myArray = Replacement(myArray);

System.Console.WriteLine();

Print2DArray(myArray);
