//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


int [,] CreateArray (int rows, int collumns, int minV, int maxV)
{
    int [,] createdArray = new int [rows, collumns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collumns; j++)
            createdArray[i, j] = new Random().Next(minV,maxV);
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

Console.WriteLine("input rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input collumns");
int collumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] ArraySort (int [,] array)
{
    int temp = 0;
    int count = 0; 
    while(count <= array.GetLength(0))
    {    
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 1; j < array.GetLength(1); j++)
            {
                if(array[i,j] > array[i,j - 1])
                {
                    temp = array[i,j - 1];
                    array[i,j - 1] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
        count += 1;
    }      
    return array;
}

int [,] newArray = CreateArray(rows, collumns, min, max);
ShowArray(newArray);

int [,] arr = ArraySort(newArray);
ShowArray(arr);










