double arraySize = InputArrayData("Input array size: ");
int arraySizeInt = Convert.ToInt32(arraySize);
double[] array = new double[arraySizeInt];
FillArrayRandom(array);
PrintArray(array);
double minValue = 0;
double maxValue = 0;
SearchMinMaxValue(array, minValue, maxValue);
double different = maxValue - minValue;
Console.Write("Different of max and min values: " + different);

double InputArrayData(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}

void FillArrayRandom(double[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-99, 100);
    }
}

void PrintArray(double[] a)
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

void SearchMinMaxValue(double[] a, double min, double max)
{
    min = 0;
    max = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] < min)
        {
            min = a[i];
        }
        if(a[i] > max)
        {
            max = a[i];
        }
    }
}