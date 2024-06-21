// See https://aka.ms/new-console-template for more information
void PrintRandom2DArray(double[,] arrayToPrint){
    for (int i = 0; i < arrayToPrint.GetLength(0); i++) {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++) {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] GenerateRandom2DArray (int m, int n) {
  double[,] array = new double[m, n];
  for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        array[i, j] = Math.Round(10.0 * new Random().NextDouble(), 1);
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
double[,] resultArray = GenerateRandom2DArray (rows, columns);
PrintRandom2DArray(resultArray);