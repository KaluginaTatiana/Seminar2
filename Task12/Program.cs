// Напишите программу, которая на вход принимает 2 числа и проверяет кратно ли второе число первому. 
// если кратно - пишет кратно,
// если не кратно - пишет не кратно, остаток ...
// 35, 5 -> не кратно, остаток 5
// 30, 5 -> кратно

Console.WriteLine("Введите первое число.");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int n2 = Convert.ToInt32(Console.ReadLine());

Task12(n1, n2);
void Task12(int number1, int number2)
{
    int ost = number1 % number2;
    if (ost == 0)
    Console.WriteLine("Кратно.");
    else
    Console.WriteLine("Не кратно. Остаток = " + ost);
}
