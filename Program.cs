// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] CreateArray ()
{
    int [,] createdArray = new int [5,5];
    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
            createdArray[i, j] = new Random().Next(1,9);
    return createdArray;        
}

void ShowArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {    
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();   
}

void ShowArr (int [,] array)
{
    int [] arr = new int [array.GetLength(0)];
    int min = 100;
    for (int i = 0; i < array.GetLength(0); i++)
    {    
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if(sum < min)
        {
            min = sum;
        } 
        Console.Write($"{arr[i] = sum} ");   
    }
    for (int i = 0; i < arr.Length; i++) 
    if(arr[i] == min)
        Console.WriteLine("строка ->" + (i + 1));
}

int [,] newArray = CreateArray();
ShowArray(newArray);
ShowArr(newArray);








