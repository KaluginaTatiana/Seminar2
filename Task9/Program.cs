// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
int n = new Random().Next(10, 100);
Task9(n);

void Task9(int currentnumber)
{
Console.WriteLine("Число:" + currentnumber);
int des = currentnumber / 10;
int ed = currentnumber % 10;
if (ed > des)
    Console.WriteLine(ed);
else if (ed < des)
    Console.WriteLine(des);
else
    Console.WriteLine("Цифры числа равны.");
}