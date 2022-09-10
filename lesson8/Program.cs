Console.Clear();
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

int [,] CreateArray (int m = 4, int n = 4)
{
    Random rnd = new Random();
    int[,] arr = new int[m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n ; j++){
            arr[i, j]  = rnd.Next(10, 99);
        }
    }
    return arr;
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int m = 4;
int n = 4;
int[,] arr = CreateArray(m, n);
System.Console.WriteLine("Исходный массив");
PrintArray(arr);

for (int i = 0; i < m; i++){

    for (int j = 1; j < n; j++){
        bool isOperation = true;
        for (int v = 0; v < n - j; v++){
            if (arr[i, v] < arr[i, v+1]) {
                int temp    = arr[i, v];
                arr[i, v]   = arr[i, v+1];
                arr[i, v+1] = temp;
                isOperation = false;
            } 
        } 
        if (isOperation) break;
    }
}
System.Console.WriteLine("Полученный массив");
PrintArray(arr);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
var arr1 = CreateArray(m , n);
int ? minSum = null; 
int nRow = -1;
System.Console.WriteLine("Массив для поиска строки с минимальной суммой");
PrintArray(arr1);

for (int i = 0; i < m ; i++){
    int temp = 0;
    for (int j = 0; j < n; j++){
        temp += arr1[i, j];
    }
    if (minSum == null || temp < minSum ) {
        minSum = temp;
        nRow = i;
    }
}
System.Console.WriteLine($"Наименьшая сумма {minSum} в строке {nRow}");

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
n = 2;
var arrA = CreateArray(n, n);
var arrB = CreateArray(n, n);
System.Console.WriteLine("Первая матрица для произведения:");
PrintArray(arrA);
System.Console.WriteLine("Вторая матрица для произведения:");
PrintArray(arrB);
//В общем случае если размер матриц заранее не известен делаем еще проверку что PrintArray(arrA);число столбцов первой матрицы совпадает с числом строк второй матрицы 
int[, ] arrC = new int[n, n];

for(int i = 0; i < n; i++) {
    for(int j = 0; j < n; j++){
        for(int k = 0; k < n; k++) {
            arrC[i, j] += arrA[i, k] * arrB[k, j];
        }
    }
}

System.Console.WriteLine("Произведение:");
PrintArray(arrC);

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

// ***! Если бы массив был размера соизмеримого с диапозоном  !***                 
// ***! нужно было бы воспользоватлься методов случайной перетасовки чисел идущих подряд !*** 

int sizeX = 2, sizeY = 2, sizeZ =2;
int x = 0, y = 0, z = 0;
int size = sizeX * sizeY * sizeZ;
int[,,] arr2 = new int[sizeX, sizeY, sizeZ];
var dict = new Dictionary<int, int>();
Random rand = new Random();

while (dict.Count < size) {
    dict.TryAdd (rand.Next(10,99), 0);
}

System.Console.WriteLine("Полученный 3х мерный массив с индексами: ");
foreach(var keyValuePair in dict)
{   
    if (z == sizeZ){
        z = 0;
        y++;
    }
    if (y == sizeY ){
        y = 0;
        x++;
    }
   
    arr2[x, y, z] = keyValuePair.Key;
    Console.Write($" {arr2[x, y, z]} ({x}, {y}, {z}) ");
    z++;
}


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
System.Console.WriteLine();
System.Console.WriteLine("Полученный массив спиралью");
m = 4;
n = 4;
int sizeArr = m * n , direction = 1, col = 0 , row = 0, maxCol = m - 1, minCol = 0, maxRow = n -1, minRow =0;
int[,] arr3 = new int [m, n];

for (int i = 1 ; i <= sizeArr; i++){
   
     arr3[col, row] = i;   
     //   System.Console.WriteLine($"{col} , {row} = {i}");
    switch (direction){
    case 1:
        row ++;
        if (row == maxRow){
            direction = 2;
            minCol++;
        }
        break;
    case 2:
        col ++;
        if (col == maxCol){
            direction = 3;
            maxRow --;
        }
        break;
    case 3:
        row --;
        if (row == minRow){
            direction = 4;
            maxCol--;
        }
        break;
    case 4:
        col --;
        if (col == minCol){
            direction = 1;
            minRow ++;
        }
        break;
    }
}

PrintArray(arr3);


