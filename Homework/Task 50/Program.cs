// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
int[,] matrix = new int[row, column];
InputMatrix(matrix);
Console.Write("Введите номер строки, начиная с ноля:: ");
row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца, начиная с ноля:: ");
column = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
result = matrix [row, column];
else 
Console.WriteLine("Заданного элемента нет в массиве.");
Console.WriteLine(result);
