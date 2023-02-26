// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


int InputData(string msg)
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

int[] ArrayCreation(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rnd.Next(minValue, maxValue);
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

int OddIndexSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

int size = InputData("Input array size");
int minValue = InputData("Input minimum value of array");
int maxValue = InputData("Input maximum value of array");
int[] array = ArrayCreation(size, minValue, maxValue);
ArrayPrint(array);
System.Console.WriteLine($"Ammount of odd index numbers is equal {OddIndexSum(array)}");