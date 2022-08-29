void Write (string text = "Введите число:"){
    System.Console.WriteLine(text);  
}


//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Write();
int a = Convert.ToInt32(Console.ReadLine());
Write();
int b = Convert.ToInt32(Console.ReadLine());

int res = a;

for (int i = 1; i < b; i++){
    res *= a;
}

Write ($" Результат равен {res}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Write();
string numStr = Console.ReadLine();
int sum = 0;

for (int i = 0; i < numStr.Length; i++){
    sum += numStr[i] - '0';             // интересная особенность c#
}
Write ($" Сумма цифр числа равна {sum}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[]  arr = new int[8];
Random rnd = new Random();

for (int i = 0 ; i < 8; i++){
    arr[i] = rnd.Next(1000);
}
Write("Массив чисел:");
foreach (int el in arr){
    Write($"{el}");
}