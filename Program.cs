/*

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Input number М(quantity number): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
 Console.Write($"Enter {i+1} number: ");
 arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Array(int[] arrayNumbers)
{
 int count = 0;
 for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"introduced numbers -> 0: {Array(arrayNumbers)} ");
*/
/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coefficient = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
  for (int i = 0; i < coefficient.GetLength(0); i++)
  {
    Console.Write($"enter coefficient {i+1} equation (y = k * x + b):");
    for (int j = 0; j < coefficient.GetLength(1); j++)
    {
      if(j==0) Console.Write($"enter coefficient k: ");
      else Console.Write($"enter coefficient b: ");
      coefficient[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coefficient)
{
  crossPoint[0] = (coefficient[1,1] - coefficient[0,1]) / (coefficient[0,0] - coefficient[1,0]);
  crossPoint[1] = crossPoint[0] * coefficient[0,0] + coefficient[0,1];
  return crossPoint;
}

void ShowEquation(double[,] coefficient)
{
  if (coefficient[0,0] == coefficient[1,0] && coefficient[0,1] == coefficient[1,1]) 
  {
    Console.Write($"сoincidence");
  }
  else if (coefficient[0,0] == coefficient[1,0] && coefficient[0,1] != coefficient[1,1]) 
  {
    Console.Write($"straight lines are parallel");
  }
  else 
  {
    Decision(coefficient);
    Console.Write($"intersection points: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
ShowEquation(coefficient);
*/