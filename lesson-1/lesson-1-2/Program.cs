// Task 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
Console.Clear();
Console.WriteLine("This program searchs the row with the minimum sum of elements.");
int numberRow = EnterUserData("Enter number of rows:");
int numberCol = EnterUserData("Enter number of columns:");
int lowerLim = EnterUserData("Enter lower limit for random range:");
int upperLim = EnterUserData("Enter upper limit for random range:");
int precision = EnterUserData("Enter precision for numbers: ");
double[,] randomArray = new double[numberRow, numberCol];
double[] rowSumArray = new double[numberRow];

Console.WriteLine();
FillArray(randomArray, numberRow, numberCol, lowerLim, upperLim, precision);
Console.WriteLine("The entered array is:");
PrintArray(randomArray);
Console.WriteLine();

for (int i = 0; i < randomArray.GetLength(0); i++)
{
double sum = 0;
for (int j = 0; j < randomArray.GetLength(1); j++)
{
sum = sum + randomArray[i, j];
}
rowSumArray[i] = Math.Round(sum, precision);
Console.WriteLine($"The sum of the row {i} is {rowSumArray[i]};");
}
Console.WriteLine();

double minSum = rowSumArray[0];
int rowMinSumNumber = 0;
for (int i = 0; i < rowSumArray.Length; i++)
{
if (minSum > rowSumArray[i])
{
minSum = rowSumArray[i];
rowMinSumNumber = i;
}
}
Console.WriteLine($"The row with number {rowMinSumNumber} has the minimum sum {minSum}");

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