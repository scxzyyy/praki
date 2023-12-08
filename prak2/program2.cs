using System;

class NumberClass
{
    private int n = 0;

    public bool SetNumber(int number)
    {
        if (number == n + 1)
        {
            n = number;
            return true;
        }
        else
        {
            n = 0;
            return false;
        }
    }

    public int GetExpectedValue()
    {
        return n + 1;
    }
}

class Program
{
    static void Main()
    {
        NumberClass numberClass = new NumberClass();

        while (true)
        {
            Console.WriteLine($"Введите ожидаемое число: {numberClass.GetExpectedValue()}");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (numberClass.SetNumber(userInput))
            {
                Console.WriteLine("Правильный! Переходим к следующему номеру.");
            }
            else
            {
                Console.WriteLine("Неверно. Заново!");
            }
        }
    }
}
