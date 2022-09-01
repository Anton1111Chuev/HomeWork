System.Console.Clear();

int[] GetIntRandomArray(int size = 4, int fromDaip = 100, int toDiap = 1000){
    int[] result = new  int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++){
        result[i] = rnd.Next(fromDaip, toDiap);
    }    
    return result;
}

double[] GetDoubleRandomArray(int size = 4, int minValue = 100, int maxValue = 1000){
    double[] result = new  double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++){
        result[i] = rnd.NextDouble() *  (maxValue - minValue) + minValue  ;
    }     
    return result;
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arr = GetIntRandomArray(5, 100, 999);
int qEvenNumber = 0;

foreach(int el in arr){
    if (el % 2 == 0 )  qEvenNumber++;   
}
System.Console.WriteLine($"масcив {string.Join(", " , arr)} ; количество четных {qEvenNumber}");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr1 = GetIntRandomArray(5);
int sumElement = 0;

for (int i = 1; i < arr1.Length; i += 2){
    sumElement += arr1[i];
}
System.Console.WriteLine($"масcив {string.Join(", " , arr1)} ; сумму элементов стоящих на нечётных позициях {sumElement}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arr2 = GetDoubleRandomArray(6, -1000, 1000);
double min = arr2[0] , max = arr2[0];

foreach (double el in arr2){
    if (min > el) min = el;
    if (max < el) max = el;
}

System.Console.WriteLine($"масcив {string.Join(", " , arr2)} ; разница между максимальным и минимальным элементом {max - min}");
