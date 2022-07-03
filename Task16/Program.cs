// Напишите программу, которая на вход принимает 2 числа и проверяет, является ли одно число квадратом другого
// 5, 25 -> да
// 25, 5 -> да
// 4, 49 -> нет

Console.WriteLine("Введите первое число.");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int n2 = Convert.ToInt32(Console.ReadLine());
Task16(n1, n2);

void Task16(int num1, int num2)
{
    if (num1 == num2*num2 | num2 == num1*num1)
    Console.WriteLine("Да.");
    else
    Console.WriteLine("Нет.");
}
