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
        double secondNumber = ReadValidSecondNumber(operation, "2-son: ");

        double result;
        bool success = Calculate(firstNumber, secondNumber, operation, out result);

        if (success)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Natija: {result}");
        }
        else
        {
            Console.WriteLine("Xato: Amal noto‘g‘ri!");
        }
    }

    // Son o‘qish
    static double ReadNumber(string prompt)
    {
        Console.Write(prompt);

        while (!double.TryParse(Console.ReadLine(), out double number))
        {
            Console.WriteLine("❌ Xato: Iltimos, to‘g‘ri son kiriting!");
            Console.Write(prompt);
        }
        return number;
    }

    // Amalni to‘g‘ri kiritilganini tekshirish
    static string ReadOperation(string prompt)
    {
        Console.Write(prompt);

        string op = Console.ReadLine();

        while (op != "+" && op != "-" && op != "*" && op != "/" && op != "%")
        {
            Console.WriteLine("❌ Xato: Faqat +, -, *, /, % amallaridan birini kiriting!");
            Console.Write(prompt);
            op = Console.ReadLine();
        }
        return op;
    }

    // 2-sonni tekshirish (0 ga bo‘lishdan himoya)
    static double ReadValidSecondNumber(string op, string prompt)
    {
        double number = ReadNumber(prompt);

        while ((op == "/" || op == "%") && number == 0)
        {
            Console.WriteLine("❌ Xato: 0 ga bo‘lish mumkin emas! Boshqa son kiriting.");
            number = ReadNumber(prompt);
        }

        return number;
    }

    // Hisoblash
    static bool Calculate(double first, double second, string op, out double result)
    {
        result = 0;

        switch (op)
        {
            case "+": result = first + second; return true;
            case "-": result = first - second; return true;
            case "*": result = first * second; return true;
            case "/": result = first / second; return true;
            case "%": result = first % second; return true;
        }
        return false;
    }
}
