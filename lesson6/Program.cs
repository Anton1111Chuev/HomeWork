Console.Clear();

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int m = new Random().Next(3, 10);
System.Console.WriteLine($"Введите {m} чисел: ");
int numberBigger0 = 0;

for (int i = 1; i <= m; i++){
    if  ( Convert.ToInt32(Console.ReadLine()) > 0 )  numberBigger0 ++;
}
System.Console.WriteLine($"Чисел больше нуля {numberBigger0}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых
// , заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double GetNumber(string text = ""){
    Console.WriteLine($"Введите  {text}: ");
    return Convert.ToDouble(Console.ReadLine());
}

Dictionary <char, double> GetLine(string text = "") {
    return  new Dictionary<char, double>()
    {
        { 'b', GetNumber($"введите b для линии номер {text}")},
        { 'k', GetNumber($"введите k для линии номер {text}")}
    };

}

Dictionary<char, double> line1 = GetLine("1");
Dictionary<char, double> line2 = GetLine("2");

double denominator = line2['k'] - line1['k'];

if (denominator == 0) {
    System.Console.WriteLine(" Точки пересечения не существует ");
}
else{
    double  x = (line1['b'] - line2['b']) / denominator;
    double  y = line1['k'] * x + line1['b'] ;

    System.Console.WriteLine($"точка пересечения ({x} ; {y})");
}
