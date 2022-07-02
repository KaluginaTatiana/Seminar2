// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 786 -> 76
// 589 -> 59
int n = new Random().Next(100, 1000);
Task11(n);

void Task11(int number)
{
Console.WriteLine("Число:" + number);
int res = number / 100 * 10 + number % 10;
Console.WriteLine("Новое число:" + res);
}