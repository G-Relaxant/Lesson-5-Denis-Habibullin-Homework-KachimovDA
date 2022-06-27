int[] array = new int[InputArrayData("Input array size: ")];
FillArrayRandom(array);
PrintArray(array);
int sumOddIndexValues = SearchAndCalculate(array);
Console.Write("Sum of values on array's odd indexes: " + sumOddIndexValues);

int InputArrayData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] a)
{
    Console.Write("[");
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]);
        if(i < a.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}

int SearchAndCalculate(int[] a)
{
    int b = 0;
    for(int i = 1; i < a.Length;)
    {
        b = b + a[i];
        i = i + 2;
    }
    return b;
}