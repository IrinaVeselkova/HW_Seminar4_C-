/*Задача 29: Напишите программу, которая задаёт массив
 из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] createmassive(int length)
{
    int[] massive = new int [length];
    for (int i=0; i< massive.Length; i++)
    {
        massive[i] = new Random().Next(100);
        
    }
    return massive;
}

void printMassive(int[] massive)
{
    foreach (var item in massive)
    {
        System.Console.Write($"{item} ");
    }
}
System.Console.Write("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] massive = createmassive(lenght);
printMassive(massive);