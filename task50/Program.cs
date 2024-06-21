// See https://aka.ms/new-console-template for more information
void PrintRandom2DArray(int[,] arrayToPrint){
    for (int i = 0; i < arrayToPrint.GetLength(0); i++) {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++) {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArrayElement(int[,] array, int i, int j){
    if ((i < 0) || (j < 0) || (i > array.GetLength(0)) || (j > array.GetLength(1))) {
        Console.Write("Такого элемента не существует");
    }    
     else {
        Console.Write($"{array[i, j]}");
     }      
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
Console.Write($"Элемент с индексами {vertIndex} и {horizIndex}: ");
PrintArrayElement(resultArray, vertIndex, horizIndex);
Console.WriteLine();
PrintRandom2DArray(resultArray);