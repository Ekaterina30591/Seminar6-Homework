//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
       
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int Count(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
    }
    return count;
}

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(length);
ShowArray(myArray);
int result = Count(myArray);

Console.WriteLine($"The user input {result} values > 0");
*/

/*

//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Input b1 value: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1 value: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2 value: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2 value: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Two lines will cross in point with X: {x} and Y: {y}");
*/