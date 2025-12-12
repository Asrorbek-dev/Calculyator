using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Calculator ===");
            Console.WriteLine("1. Qo‘shish (+)");
            Console.WriteLine("2. Ayirish (-)");
            Console.WriteLine("3. Ko‘paytirish (*)");
            Console.WriteLine("4. Bo‘lish (/)");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlang: ");

            int option = int.Parse(Console.ReadLine());

            if (option == 5)
                break;

            Console.Write("1-sonni kiriting: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("2-sonni kiriting: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    Console.WriteLine($"Natija: {a + b}");
                    break;

                case 2:
                    Console.WriteLine($"Natija: {a - b}");
                    break;

                case 3:
                    Console.WriteLine($"Natija: {a * b}");
                    break;

                case 4:
                    if (b == 0)
                        Console.WriteLine("0 ga bo‘lib bo‘lmaydi!");
                    else
                        Console.WriteLine($"Natija: {a / b}");
                    break;

                default:
                    Console.WriteLine("Noto‘g‘ri tanlov!");
                    break;
            }

            Console.WriteLine("\nDavom ettirish uchun ENTER bosing...");
            Console.ReadLine();
        }
    }
}
