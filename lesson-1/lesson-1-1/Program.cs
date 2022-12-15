// Task 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
Console.Clear();
Console.WriteLine("This program sorts rows of the entered array.");
int numberRow = EnterUserData("Enter number of rows:");
int numberCol = EnterUserData("Enter number of columns:");
int lowerLim = EnterUserData("Enter lower limit for random range:");
int upperLim = EnterUserData("Enter upper limit for random range:");
int precision = EnterUserData("Enter precision for numbers: ");
double[,] randomArray = new double[numberRow, numberCol];

FillArray(randomArray, numberRow, numberCol, lowerLim, upperLim, precision);
Console.WriteLine("The entered array is:");
PrintArray(randomArray);
SortArray();
Console.WriteLine("The sorted array is:");
PrintArray(randomArray);

void SortArray()
{
double buffer = 0;
for (int i = 0; i < randomArray.GetLength(0); i++)
{
for (int j = 1; j < randomArray.GetLength(1); j++)
{
for (int n = 1; n < randomArray.GetLength(1); n++)
{
if (randomArray[i, n] > randomArray[i, n - 1])
{
buffer = randomArray[i, n - 1];
randomArray[i, n - 1] = randomArray[i, n];
randomArray[i, n] = buffer;
}
}
}
}
}

double[,] FillArray(double[,] array, int numberRow, int numberCol, int lowerLim, int upperLim, int precision)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
double randomNum = new Random().NextDouble() * (upperLim - lowerLim);
randomArray[i, j] = Math.Round(randomNum, precision);
}
}
return array;
}

void PrintArray(double[,] array)
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

int EnterUserData(string nameUserData)
{
Console.Write($"{nameUserData}");
return Convert.ToInt32(Console.ReadLine());
}