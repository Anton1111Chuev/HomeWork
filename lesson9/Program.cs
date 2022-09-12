Console.Clear();
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Random rand = new Random();

int m = rand.Next(1, 50);
int n = rand.Next(m, m + 50);

System.Console.WriteLine($"Числа от {m} до {n}: ");

IEnumerable<int> numbers = Enumerable.Range(m, n - m + 1);

System.Console.WriteLine(String.Join(" ", numbers));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

System.Console.WriteLine($"Сумма элементов: {numbers.Sum()} ");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int CalcFunkionAkkerman(int m, int n) {

    if (m == 0) return n + 1;

    if (n == 0) return CalcFunkionAkkerman(m - 1, 1);
    
    return CalcFunkionAkkerman (m -1, CalcFunkionAkkerman(m, n - 1));
}
int m1 = 3;
int n1 = 2;
System.Console.WriteLine($"Функция Аккермана({m1},{n1}): {CalcFunkionAkkerman(m1, n1)}");