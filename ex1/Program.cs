/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int ReadInt(string msg)// объявляем функцию msg строковую
{
Console.WriteLine(msg);//пишет на экран параметр msg
string a = Console.ReadLine();
int numb;
numb = int.Parse(a);//преобразуем строку в число
return numb;// возврат из функции
}
int numb1 = ReadInt("Введите первое число:");
int numb2 = ReadInt("Введите второе число:");

System.Console.WriteLine($"{numb1}^{numb2} = {Math.Pow(numb1,numb2)}");
