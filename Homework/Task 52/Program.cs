// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
void InputMatrix(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(-10,11);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}
void MiddleNumber(int[, ] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = 0;
        int i = 0;
        while (i < matrix.GetLength(0))
            {
                result += matrix[i, j];
                i++;
            }
        Console.WriteLine($"Столбец {j + 1} = {result / matrix.GetLength(0)}");
    }
}
    
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
MiddleNumber(matrix);
