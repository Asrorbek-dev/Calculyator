using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("         Oddiy Kalkulyator         ");
        Console.WriteLine("===================================");

        double firstNumber = ReadNumber("1-son: ");
        string operation = ReadOperation("Amal (+, -, *, /, %): ");
        double secondNumber = ReadNumber("2-son: ");

        double result;
        bool success = Calculate(firstNumber, secondNumber, operation, out result);

        if (success)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Natija: {result}");
        }
        else
        {
            Console.WriteLine("Xato: Amal noto'g'ri yoki nolga bo‘lish!");
        }
    }

    // Son o'qish uchun metod
    static double ReadNumber(string prompt)
    {
        Console.Write(prompt);

        while (!double.TryParse(Console.ReadLine(), out double number))
        {
            Console.WriteLine("Iltimos, to'g'ri son kiriting!");
            Console.Write(prompt);
        }
        return number;
    }

    // Amal o'qish uchun metod
    static string ReadOperation(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    // Hisoblashni bajaruvchi metod
    static bool Calculate(double first, double second, string op, out double result)
    {
        result = 0;
        switch (op)
        {
            case "+":
                result = first + second;
                return true;
            case "-":
                result = first - second;
                return true;
            case "*":
                result = first * second;
                return true;
            case "/":
                if (second == 0) return false;
                result = first / second;
                return true;
            case "%":
                if (second == 0) return false;
                result = first % second;
                return true;
            default:
                return false;
        }
    }
}
