int[] CreateArray()
{
    int[] Array = new int [8];
    Random number = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(0, 100);
    }
    return Array;
}

void PrintArray(int[] array)
{
    int length = 1;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}, {array[3]}");
        Console.WriteLine($"{array[4]}, {array[5]}, {array[6]}");
    }
}
int[] salamPopolam = CreateArray();
PrintArray(salamPopolam);