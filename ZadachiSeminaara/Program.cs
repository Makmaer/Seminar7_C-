double[,] RandomD2Array(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;                
    
}

double[,] RandomD2ArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i,j] = Math.Round(new Random().Next(minValue, maxValue ) + new Random().NextDouble(), 3)  ;

    return newArray;                
    
}

void ShowD2Array(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
     {   for (int j = 0; j < array.GetLength(1); j++)
           System.Console.Write(array[i,j] + "  ");
           System.Console.WriteLine();   
     }        
    
}

void ShowD2ArrayDouble(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
     {   for (int j = 0; j < array.GetLength(1); j++)
           System.Console.Write(array[i,j] + " ");
           System.Console.WriteLine();   
     }        
    
}

int[,] D2Array(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i,j] = i + j;

    return newArray;                
    
}

int[,] D2ArrayChetniyIndex(int[,] array)
{
       for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
             array[i,j] *= array [i,j];

    return array;                
    
}

double SumEllementsArray(double[,] array)
{      double sum =0;
if(array.GetLength(0) == array.GetLength(1))
        { for (int i = 0; i < array.GetLength(0); i++) sum += array[i,i];
        return sum;
        }
    return -1;                
}

double[,] PoiskChisla2D(double[,] array, double chislo)
{
    double[,] newArray = new double[10,2]; newArray[0,0] = -1; newArray[0,1] = -1; int str = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)          
           { if (array[i,j] == chislo) {newArray[str,0] = i+1; newArray[str,1] = j+1; str++; }}
    
    return newArray;
}

void PrintMasIntIndex (double[,] array)
{Console.WriteLine("Расположение эл-та (строка, столбец) : ");
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
            if(array[i,j] == 0) break;
            else if (array[i,j] == (-1)) {Console.WriteLine("Искомый эл-т отсутствует"); break;}
            else Console.Write( array[i,j] + " ");
            }
        Console.WriteLine(); 
        }
            
    
}

double[] SummaPoStolbcam (double[,] array)
{
    double[] sumArray = new double[array.GetLength(1)];
   
    for (int j = 0; j < array.GetLength(1); j++)
    { sumArray[j] = 0;
        for (int i = 0; i < array.GetLength(0); i++)
         {
            sumArray[j] = sumArray[j] + array[i,j];
         }
    }
    return sumArray;
}

void PrintMasDouble (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] SredneArifm( double[] array, int rows)
{
    double[] SredArif = new double [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        SredArif[i]=array[i]/rows;
    }
    return SredArif;
}
/*
System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = RandomD2Array(m, n, 1, 9);
ShowD2Array(myArray);
*/

//## Задача 2.
//Создать двумерный массив.  
//Каждый эл-т массива находится по формуле a[i,j]= i+j
//Вывести массив на экран.
/*
System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowD2Array(D2Array (n,m)); */

//## Задача 3. 
//Создаем двумерный массив.
//Находим эл-ты у которых оба индекса четные.
//У этих элементов значения меняем на квадрат этого значения.
/*
System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = RandomD2Array(m, n, 1, 9);
ShowD2Array(myArray);
D2ArrayChetniyIndex(myArray);
System.Console.WriteLine();
ShowD2Array(myArray);
*/

//## Задача 4.
//В массиве найти сумму эл-тов на главной диагонали.
/*
System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = RandomD2Array(m, n, 1, 9);
ShowD2Array(myArray);
System.Console.WriteLine();
System.Console.Write(SumEllementsArray(myArray));
*/

//## Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = RandomD2ArrayDouble(m, n, 1, 9);
ShowD2ArrayDouble(myArray);
*/

//## Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = RandomD2Array(m, n, 1, 9);
ShowD2Array(myArray);
System.Console.Write("Введите искомое число: ");
int ch = Convert.ToInt32(Console.ReadLine());
PrintMasIntIndex(PoiskChisla2D (myArray, ch));
*/

//## Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = RandomD2Array(m, n, 1, 9);
double[] rez = SummaPoStolbcam(myArray);
ShowD2Array(myArray);
//PrintMasDouble(rez);
PrintMasDouble(SredneArifm(rez,m));


