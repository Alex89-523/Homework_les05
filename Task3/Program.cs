// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Пример
// 4 3 1 => Строка с индексом 0
// 2 6 9 
// 4 6 2 



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


System.Console.WriteLine("Введите размер массива a на b и диапазон случайных значений: ");
int a = InputNumbers("Введите a: ");
int b = InputNumbers("Введите b: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[a, b];
Create2DArray(array);
Print2DArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 0; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

System.Console.WriteLine($"\n{minSumLine + 1} - строка с наименьшей суммой элементов");

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int InputNumbers(string input)
{
    System.Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void Create2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random(). Next(range);
        }
    }
}
