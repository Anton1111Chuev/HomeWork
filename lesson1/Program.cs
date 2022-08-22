
// // Задача 2
// //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Clear();

// Console.WriteLine ("Введите первое число ");
// int number1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine ("Введите второе число ");
// int number2 = int.Parse(Console.ReadLine()!);

// if (number1 > number2) {
//     Console.WriteLine("Первое число больше");
// }
// else if (number2 > number1) {
//     Console.WriteLine("Второе число больше");
// }
// else {
//     Console.WriteLine("Числа равны");
// }

// //Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine ("Введите первое число ");
// number1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine ("Введите второе число ");
// number2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine ("Введите третье число ");
// int number3 = int.Parse(Console.ReadLine()!);

// int max = number1;

// if (max < number2) {
//      max = number2;
// }
// if (max < number3) {
//     max = number3;
// }
// Console.WriteLine ("Максимум " + max);

// //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine ("Введите  число ");
// int number = int.Parse(Console.ReadLine()!);

// if (number % 2 == 0 ){
//    Console.WriteLine ("Число четное");
// }
// else {
//     Console.WriteLine ("Число  не четное");
// }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Введите  число N ");
int numberN = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= numberN ; i+=2) {
    Console.WriteLine (i);
}