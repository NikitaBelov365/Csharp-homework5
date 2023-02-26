// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int InputArraySize(string msg)
{
    System.Console.WriteLine(msg);
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Only integer pls");
    Environment.Exit(1);
    return 0;
}

int[] ArrayCreation(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rnd.Next(100, 1000);
    }
    return array;
}

void ArrayPrint(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine();
}

int EvenNumAmmount(int[] array)
{
    int ammount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            ammount +=1;
        }
    }
    return ammount;
}

int size = InputArraySize("Input array size");
int[] array = ArrayCreation(size);
ArrayPrint(array);
System.Console.WriteLine($"Ammount of even numbers in array is equal {EvenNumAmmount(array)}");