double arraySize = InputArrayData("Input array size: ");
int arraySizeInt = Convert.ToInt32(arraySize);
double[] array = new double[arraySizeInt];
FillArrayRandom(array);
PrintArray(array);
double minValue = array[0];
double maxValue = array[0];
//SearchMinMaxValue(array, minValue, maxValue);       // Вариант с процедурой, не работает, почему то не сохраняет или не считает вводные параметры (minValue и maxValue)
minValue = SearchMinValue(array, minValue);         // Вариант 2 (с функцией)
maxValue = SearchMaxValue(array, maxValue);         // Варинат 2 (с функцией)
Console.WriteLine("Max value: " + maxValue + ", " + "Min value: " + minValue);
double difference = maxValue - minValue;
Console.Write("Difference of max and min values: " + difference);

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

/*void SearchMinMaxValue(double[] a, double min, double max)         // Вариант с процедурой, не работает, почему то не сохраняет или не считает вводные параметры (minValue и maxValue)
{
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
}*/

double SearchMinValue(double[] a, double min)
{
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] < min)
        {
            min = a[i];
        }
    }
    return min;    
}

double SearchMaxValue(double[] a, double max)
{
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] > max)
        {
            max = a[i];
        }
    }
    return max;    
}

// Спасибо за коментарии по домашке ;)