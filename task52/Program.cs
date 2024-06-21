// See https://aka.ms/new-console-template for more information
void FindSum(int[,] arrayToCalc){ 
    for (int j = 0; j < arrayToCalc.GetLength(1); j++) {
        double sum = 0.0;
        for (int i = 0; i < arrayToCalc.GetLength(0); i++) {
            sum += arrayToCalc[i, j];
        }
        double average = sum / arrayToCalc.GetLength(0);
        Console.WriteLine($"Среднеарифметическая сумма столбца {j} равна: {average}");
    }
}

void PrintRandom2DArray(int[,] arrayToPrint){
    for (int i = 0; i < arrayToPrint.GetLength(0); i++) {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++) {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
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
PrintRandom2DArray(resultArray);
FindSum(resultArray);