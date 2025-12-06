
Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("===================================");
        Console.WriteLine("         Oddiy Kalkulyator       ");
        Console.WriteLine("===================================");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1-son: ");
        double FirstNumber = double.Parse(Console.ReadLine());

        Console.Write("Amal : ");
        string amal = Console.ReadLine();

        Console.Write("2-son: ");
        Console.ResetColor();
        double SecondNumber = double.Parse(Console.ReadLine());

        double result = 0;

        switch (amal)
        {
            case "+":
                result = FirstNumber + SecondNumber;
                break;
            case "-":
                result = FirstNumber - SecondNumber;
                break;
            case "*":
                result = FirstNumber * SecondNumber;
                break;
            case "/":
                result = FirstNumber / SecondNumber;
                break;
            case "%":
               result = FirstNumber % SecondNumber;
               break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Xato: Amal noto'g'ri kiritildi!");
                Console.ResetColor();
                return;
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("===================================");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Natija: {result} ");
        Console.ResetColor();

       