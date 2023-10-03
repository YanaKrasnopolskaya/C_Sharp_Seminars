// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintOutDouble(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]:F1}; ");        //:F1 округление до одного знака после запятой           
    }
    
    Console.Write($"{arr[^1]:F1}");
}

double MaxElementArray(double[] arr)
{
    int index = 0;
    double maxElement = arr[index];

    while (index < arr.Length)
    {
        if (arr[index] > maxElement) maxElement = arr[index];

        index ++;  
    }

    return maxElement;
}

double MinElementArray(double[] arr)
{  
    int index = 0;
    double minElement = arr[index];

    while (index < arr.Length)
    {
        if (arr[index] < minElement) minElement = arr[index];
        
        index ++;
    }
    
    return minElement;    
}

double DifferenceElementsArray(double elem1, double elem2)
{
    double maxElem = elem1;
    double minElem = elem2;
    
    if (elem2 > maxElem)
    {
        maxElem = elem2; 
        minElem = elem1;
    } 
    
    double res = maxElem - minElem;
    
    return res;
}

double[] array = CreateArrayRndDouble(10, 10, 100);
Console.Write("[");
PrintOutDouble(array);
Console.Write("]");
Console.WriteLine();
double maxElement = MaxElementArray(array);
double minElement = MinElementArray(array);
double result = DifferenceElementsArray(maxElement, minElement);
Console.WriteLine($"Разница между максимальным элементом: {maxElement:F1} и минимальным элементом: {minElement:F1} --> {result:F1}");