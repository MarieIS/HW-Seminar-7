// See https://aka.ms/new-console-template for more information
// add the printing of array and checking the ranges
void PrintArrayElement(int[,] array, int i, int j){
    Console.Write($"Элемент массива с индексами {i} и {j}: {array[i, j]}");
}

int[,] GenerateRandom2DArray (int m, int n, int minValue, int maxValue) {
  int[,] array = new int[m, n];
  for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        array[i, j] = new Random().Next(minValue, maxValue+1);
    }
  }
  return array;
}

int GetNumberAmount(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetNumberAmount("Введите желаемое количество строк: ");
int columns = GetNumberAmount("Введите желаемое количество столбцов: ");
int[,] resultArray = GenerateRandom2DArray (rows, columns, 0, 9);
int vertIndex = GetNumberAmount("Введите индекс строки элемента массива: ");
int horizIndex = GetNumberAmount("Введите индекс столбца элемента массива: ");
PrintArrayElement(resultArray, vertIndex, horizIndex);