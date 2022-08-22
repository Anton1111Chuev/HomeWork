void Write (string text = "Введите число:"){
    System.Console.WriteLine(text);  
}
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Write();

int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine((number%100 - number%10) / 10 );

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Write();
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 100) {
   Write ("У введенного числа нет третей цифры");
}
else {
    System.Console.WriteLine( (number1%1000  - number1%100)/100);
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Write("Введите число дня недели");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek == 6 || dayOfWeek == 7) {
    Write("Это выходной");
}
else{
    Write("Это не выходной");
}


