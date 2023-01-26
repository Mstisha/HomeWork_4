int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число!");
        }
    }

    return result;
}
int numberA = GetNumber("Введите число:");
int numberB = GetNumber("Введите число возведения в степень:");
int MultipleNumbers(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine(MultipleNumbers(numberA, numberB));