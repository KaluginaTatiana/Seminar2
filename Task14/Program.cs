// Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 161 -> да
Console.WriteLine("Введите число для проверки кратности 7 и 23 одновременно.");
int n = Convert.ToInt32(Console.ReadLine());
Task14(n);

void Task14(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
        Console.WriteLine("Кратно.");
    else
        Console.WriteLine("Не кратно.");  
}
