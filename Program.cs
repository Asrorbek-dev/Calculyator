using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("===================================");
        Console.WriteLine("         Oddiy Kalkulyator       ");
        Console.WriteLine("===================================");
        Console.ResetColor();

        double firstNumber = ReadNumber("1-son: ");
        string operation = ReadOperation("Amal: ");
        double secondNumber = ReadNumber("2-son: ");

        double result;
        bool success = Calculate(firstNumber, secondNumber, operation, out result);

        if (success)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Natija: {result}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Xato: Amal noto'g'ri kiritildi!");
            Console.ResetColor();
        }
    }

    // Son o'qish uchun metod
    static double ReadNumber(string prompt)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(prompt);
        Console.ResetColor();

        while (!double.TryParse(Console.ReadLine(), out double number))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Iltimos, to'g'ri son kiriting!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(prompt);
            Console.ResetColor();
        }
        return number;
    }

    // Amal o'qish uchun metod
    static string ReadOperation(string prompt)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(prompt);
        Console.ResetColor();
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
                if (second == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Xato: Nolga bo‘lish mumkin emas!");
                    Console.ResetColor();
                    return false;
                }
                result = first / second;
                return true;
            case "%":
                if (second == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Xato: Nolga bo‘lish mumkin emas!");
                    Console.ResetColor();
                    return false;
                }
                result = first % second;
                return true;
            default:
                return false;
        }
    }
}
