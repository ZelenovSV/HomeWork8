//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки
// двумерного массива 

void Task54()
{
    Console.WriteLine("Task 54");
    int[,] array = FillArray();
    FillElement(array);
    PrintElements(array);
    Console.WriteLine();
    ArrangeElement(array);
}

//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

void Task56()
{
    Console.WriteLine("Task 56");
    int[,] array = FillArray();
    FillElement(array);
    PrintElements(array);
    Console.WriteLine();
    SumStringElements(array);
    MinimumSumString(SumStringElements(array));
}

//Задача 58: Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.

void Task58()
{
    Console.WriteLine("Task 58");
    int[,] firstArray = FillArray();
    FillElement(firstArray);
    int[,] secondArray = FillArray();
    FillElement(secondArray);
    PrintElements(firstArray);
    Console.WriteLine();
    PrintElements(secondArray);
    MultiplicationArray(firstArray, secondArray);
}

//Задача 60: Сформируйте трёхмерный массив из неповторяющихся
//двузначных чисел. Напишите программу, которая будет построчно
//выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

void Task60()
{
    Console.WriteLine("Task 60");
    int[,,] spatialArray = new int[2,2,2];
    FillSpatialArray(spatialArray);
    PrintIndex(spatialArray);
}

//Задача 62. Напишите программу, которая заполнит
//спирально массив 4 на 4.

void Task62()
{
   Console.WriteLine("Task 62");
   int[,] array = FillArray();
    FillElement(array); 
    SpiralElements(array);
}

Main();

void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("Enter command");
        string command = Console.ReadLine();

        switch (command)
        {
            case "Task 54":
                Task54();
                break;
            case "Task 56":
                Task56();
                break;
            case "Task 58":
                Task58();
                break;
            case "Task 60":
                Task60();
                break;    
            case "Task 62":
                Task62();
                break;        
            case "exit":
                isWork = false;
                break;
        }
    }
}

int[,] FillArray()
{
    Console.WriteLine("Введите количество строк: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int b = int.Parse(Console.ReadLine());
    return new int [a,b];
}

void FillElement(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array [i,j] = new Random().Next(1,10);
                }
        }
}

void PrintElements(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}");   
        }
        Console.WriteLine();
    }
}

void ArrangeElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
                {
                    if (array[i,k] < array[i,k+1] )
                    {
                    int z = array[i,k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = z;
                    }
                }   
        }
    }
    PrintElements(array);
}

int[] SumStringElements(int[,] array) 
{
    int[] sumString = new int[array.GetLength(0)];   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        sumString[i] = sum;  
    }
    return sumString;
}

void MinimumSumString(int[] array)
{
    int minSumElements = array[0];
    int line = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSumElements)
        {
            minSumElements = array[i];
            line = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {line}");
}

void MultiplicationArray(int[,] a, int[,] b)
{
    if(a.GetLength(1) == b.GetLength(0))
    {
        int[,] c = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                for (int t = 0; t < a.GetLength(1); t++)
                {
                    c[i,j] += a[i,t]*b[t,j];  
                }
            }  
        }
   PrintElements(c);
    }
    else
    {
        Console.WriteLine("Перемножение матриц невозможно");
    }    
}

void FillSpatialArray(int[,,] arr)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; i < arr.GetLength(2); i++)
            {
                arr[k,i,j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {       
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");    
            }
        }   
    }
Console.WriteLine();
}

void PrintSpiralArray(int[,] arr)
{
    Console.WriteLine("Спиральный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] / 10 <= 0)
            Console.Write($" {arr[i,j]} ");
            else 
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SpiralElements (int[,] arr)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= arr.GetLength(0)*arr.GetLength(1))
    {
        arr[i,j] = temp;
        temp++;
        if (i<= j + 1 && i + j < arr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= arr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > arr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    PrintSpiralArray(arr);
}