int[] array = new int[InputArrayData("Input array size: ")];
FillArrayRandom(array);
PrintArray(array);
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.Write("Count of even numbers in array: " + count);





int InputArrayData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100, 1000);
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