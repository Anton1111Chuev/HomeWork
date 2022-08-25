
void Write (string text = "Введите число:"){
    System.Console.WriteLine(text);  
}
int[] ReadPoint(string pointNumber){
    int[] result = new int[3];
    Write("Введите координаты точки номер " + pointNumber);
    for (int i = 0 ; i < 3 ; i++){
      result[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return result;
}

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Write();
string s = Console.ReadLine();
Console.WriteLine(s.Length);

int l = s.Length / 2;

bool isPolimorf = true;

for (int i = 0; i < l; i ++ ) {
    if (s[i] != s[s.Length - i - 1]) {
        isPolimorf = false;
        break;
    }
}
Write("" + isPolimorf);

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int[] point1 = ReadPoint("1");
int[] point2 = ReadPoint("2");

int sum = 0;

for (int i = 0; i < 3; i++){
    sum =+ (point2[i] - point1[i] ) * (point2[i] + point1[i]); 
}

Write ("расстояние между точками " + Math.Sqrt(Convert.ToDouble(sum) ));


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Write();
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n ; i++){
    Write ("" + i*i*i);
}
