﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] CreateArrayRndint(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}");// ^1 последний элемент массива
}

bool FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }
    return false;
}
int GetUserInput(string msg)
{
    Console.Write($"{msg}");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int numFind = GetUserInput("Введите число для поиска: ");
int[] randArr = CreateArrayRndint(8, 1, 10);
Console.Write("[");
PrintOut(randArr);
Console.Write("] --> ");
bool findNumber = FindNumber(randArr,numFind);
Console.WriteLine(findNumber? "Заданное число найдено" : "Заданное число не найдено");