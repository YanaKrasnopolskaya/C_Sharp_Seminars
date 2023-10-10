// Задача 40: 
// 1. Напишите программу, которая принимает на вход три числа 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.


int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool TriangleExistence(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

int sideA = GetUserInput("Введите длинну первой стороны: ");
int sideB = GetUserInput("Введите длинну второй стороны: ");
int sideC = GetUserInput("Введите длинну третьей стороны: ");


if (TriangleExistence(sideA, sideB, sideC))
{
    Console.WriteLine("Треугольник с заданными значениями существует!");
}
else Console.WriteLine("Треугольник с заданными значениями не существует!");