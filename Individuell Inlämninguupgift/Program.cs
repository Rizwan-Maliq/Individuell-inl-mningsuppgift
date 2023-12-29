using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Välkomnande meddelande
        Console.WriteLine("Välkommen till miniräknaren!");

        // En lista för att spara historik för räkningar
        List<double> resultHistory = new List<double>();

        // Loop för att fortsätta eller avsluta programmet
        while (true)
        {
            // Användaren matar in tal och matematiska operation
            Console.Write("Ange det första talet: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Ogiltig inmatning. Ange numeriska värden.");
                continue;
            }

            Console.Write("Ange matematisk operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write("Ange det andra talet: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Ogiltig inmatning. Ange numeriska värden.");
                continue;
            }

            // Kontrollera om användaren matar in giltiga tal
            if (double.IsNaN(num1) || double.IsNaN(num2))
            {
                Console.WriteLine("Ogiltig inmatning. Ange numeriska värden.");
                continue;
            }

            // Utför beräkning baserat på operatören
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ogiltig inmatning! Kan inte dela med 0.");
                        continue;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Ogiltig operator. Ange endast +, -, *, /.");
                    continue;
            }

            // Lägga resultat till listan
            resultHistory.Add(result);

            // Visa resultat
            Console.WriteLine("Resultat: " + result);

            // Fråga användaren om den vill visa tidigare resultat.
            Console.Write("Vill du visa tidigare resultat? (ja/nej): ");
            string showHistory = Console.ReadLine();

            // Visa tidigare resultat
            if (showHistory.ToLower() == "ja")
            {
                Console.WriteLine("Resultathistorik: " + string.Join(", ", resultHistory));
            }

            // Fråga användaren om den vill avsluta eller fortsätta
            Console.Write("Vill du avsluta programmet? (ja/nej): ");
            string exitChoice = Console.ReadLine();
            if (exitChoice.ToLower() == "ja")
            {
                break;
            }
        }

        // Avslutningsmeddelande
        Console.WriteLine("Tack för att du använde miniräknaren!");
    }
}
