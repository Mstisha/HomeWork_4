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
int numberN = GetNumber("Введите число:");
int SumNumber(int numberN)
{   
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
    return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}" );