/*Задача 27: Напишите программу, которая принимает на вход число и
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int ReadInt(string msg)// объявляем функцию msg строковую
{
    Console.WriteLine(msg);//пишет на экран параметр msg
    string a = Console.ReadLine();
    int numb;
    numb = int.Parse(a);//преобразуем строку в число
    return numb;// возврат из функции
}
int numb = ReadInt("Введите число:");
int sum = 0;
for (int i = 0; i <= numb+10; i++)
{
    sum = sum + numb % 10;
    numb = numb / 10;
}
System.Console.WriteLine(sum);