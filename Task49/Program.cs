﻿// 49. Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{       
    //                        0      1
    int[,] matrix = new int[rows, columns]; // 3 x 4

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        Console.Write("│");
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("│");
    }
}

void ReplaceEvenIndexElemSquare(int[,] matrix) {
 for (int i = 0; i < matrix.GetLength(0); i+=2)
 {
    for (int j = 0; j < matrix.GetLength(1); j+=2)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i,j] *= matrix[i,j];
        }
    }
 }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

ReplaceEvenIndexElemSquare(array2d);
PrintMatrix(array2d);