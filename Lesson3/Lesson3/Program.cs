// See https://aka.ms/new-console-template for more information

int[] array;
int arraySize;
while (true)
{
    Console.WriteLine($"Enter size of array it must be greater then 1");
    arraySize = ReadNumber();
    if (arraySize > 1)
    {
        array = new int[arraySize];
        break;
    }
    Console.WriteLine($"Size of array must be greater than 1.\n You entered {arraySize}");
}

for(var i=0; i<arraySize; i++)
{
    Console.WriteLine($"Enter {i} member of array");
    array[i] = ReadNumber();
}
Array.Sort(array);

var firstMax = array[array.Length - 1];
int? secondMax = null;
for (var i = arraySize-1; i >= 0; i--)
{
    if (array[i] == firstMax)
        continue;
    secondMax=array[i];
    break;
}
if (secondMax != null)
{
    Console.WriteLine($"The second max value is {secondMax}");
}
else
{
    Console.WriteLine($"all members of array are the same");
}
int ReadNumber()
{
    while (true)
    {
        Console.WriteLine("It must be an integer number");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            return result;
        }
        Console.WriteLine("it's not an integer number");
    }
}