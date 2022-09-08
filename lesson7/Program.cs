void PrintArray <T> (T[,] array){
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for (int i = 0; i < m; i++){
        for (int j = 0; j < n ; j++){
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Random rnd = new Random();
int n = rnd.Next(2, 5);
int m = rnd.Next(2, 5);
double[,] arr = new double[m, n];

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n ; j++){
        arr[i, j]  = rnd.NextDouble() * 100;
     }
}

PrintArray(arr);

//Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
System.Console.WriteLine("Введите позиции  строки и столбца массива");
int pRow = Convert.ToInt32(Console.ReadLine());
int pColumn = Convert.ToInt32(Console.ReadLine());

if ( pRow < arr.GetLength(0) && pColumn < arr.GetLength(1) ) {
    System.Console.WriteLine(arr[pRow, pColumn]);
}
else {
    System.Console.WriteLine("Элемента с такой позицией не существует");
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] arrInt = new int[m, n];

System.Console.WriteLine("Средние арифметические ");

for (int j = 0; j < n ; j++){
    int sum = 0;
    for (int i = 0; i < m; i++) {
        arrInt[i, j]  = rnd.Next(1, 100);
        sum += arrInt[i, j];
     }
     System.Console.WriteLine($"Для столбца {j} : {sum/m}");
}
PrintArray(arrInt);
