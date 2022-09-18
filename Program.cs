// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/* int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

int[,] SortArray(int[,] array)
{
	int temp = 0;
	for (int n = 0; n < array.GetLength(1); n++)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1) - 1; j++)
			{
				if (array[i, j] < array[i, j + 1])
				{
					temp = array[i, j];
					array[i, j] = array[i, j + 1];
					array[i, j + 1] = temp;
				}
			}
		}
	}
	return array;
}

Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
PrintArray(SortArray(array)); */



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/* int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

List<int> SummList(int[,] array)
{
	var summList = new List<int>();

	for (int i = 0; i < array.GetLength(0); i++)
	{
		int summ = 0;
		for (int j = 0; j < array.GetLength(1); j++)
		{
			summ += array[i, j];
		}
		summList.Add(summ);
		Console.WriteLine(summList[i]);
	}
	return summList;
}

void PrintMinimumString(List<int> minString)
{
	for (int i = 0; i < minString.Count; i++)
	{
		if (minString[i] == minString.Min())
			Console.WriteLine("Строчка с наименьшей суммой = " + (i + 1));
	}
}

Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
var summList = SummList(array);
Console.WriteLine();
PrintMinimumString(summList); */



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = FillArray(2, 2);
int[,] array2 = FillArray(2, 2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
int[,] resultArray = new int[2, 2];
Console.WriteLine();
PrintArray(Matrix(array1, array2, resultArray));


int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

int[,] Matrix(int[,] array1, int[,] array2, int[,] resulArray)
{
	for (int i = 0; i < resultArray.GetLength(0); i++)
	{
		for (int j = 0; j < resultArray.GetLength(1); j++)
		{
			int sum = 0;
			for (int k = 0; k < array1.GetLength(1); k++)
			{
				sum += array1[i, k] * array2[k, j];
			}
			resultArray[i, j] = sum;
		}
	}
	return resulArray;
}