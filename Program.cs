

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
