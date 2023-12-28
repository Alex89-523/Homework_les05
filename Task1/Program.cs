// Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Пример
// 4 3 1 (1,2) => 9
// 2 6 9 

System.Console.WriteLine("Введите строку: ");
int line = Convert.ToInt32(Console.ReadLine()) - 1;

System.Console.WriteLine("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine()) - 1;

int x = 4;
int y = 4;
int[,] array = new int [x, y];

Random rand = new Random();

System.Console.WriteLine("Исходный массив: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(0, 9);
        System.Console.Write("{0} ", array[i, j]);
    }
    System.Console.WriteLine();
    
}

if (line < 0 | line > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(0) - 1)
{
    System.Console.WriteLine("Элемент не существует ");
}
else
{
    System.Console.WriteLine("Значение элемента массива = {0}", array[line, column]);
}
Console.ReadLine();