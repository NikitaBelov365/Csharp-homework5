// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int InputArraySize(string msg)
{
    System.Console.WriteLine(msg);
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Only integer for size pls");
    Environment.Exit(1);
    return 0;
}

double InputMinMax(string msg)
{
    System.Console.WriteLine(msg);
    if(double.TryParse(Console.ReadLine(), out double value))
    {
        return value;
    }
    System.Console.WriteLine("Only float of int pls");
    Environment.Exit(1);
    return 0;
}

double[] ArrayCreation(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= Math.Round(rnd.NextDouble()*(maxValue-minValue)+minValue,2);
    }
    return array;
}

void ArrayPrint(double[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine();
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
        if(array[i]<min)
        {
            min = array[i];
        }
    }
    System.Console.WriteLine($"Maximum value is: {max}");
    System.Console.WriteLine($"Minimum value is: {min}");
    double diff = max - min;
    return Math.Round(diff, 3);
}

int size = InputArraySize("Input size of array");
double minValue = InputMinMax("Input minimum value to create an array");
double maxValue = InputMinMax("Input maximum value to create an array");
double[] array = ArrayCreation(size, minValue, maxValue);
ArrayPrint(array);
System.Console.WriteLine($"Difference between max and min value of array is equal {Difference(array)}");