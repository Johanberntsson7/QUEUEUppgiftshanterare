using System;
using System.Collections;
using System.Diagnostics;

namespace QUEUEUppgiftshanterare;

class Program
{
    static void Main(string[] args)
    {
        // Lära sig hantera data i rätt ordning (FIFO – First In, First Out).

        // Implementera ett enkelt uppgiftshanteringssystem med Queue<string>.
        


        // Implementera ett enkelt uppgiftshanteringssystem med Queue<string>.
        Queue<string> uppgifter = new Queue<string>();
        bool KeepRunning = true;
        
        while (KeepRunning)
        { 
        // I menyn ska användaren kunna:
        Console.WriteLine("Välkommen till uppgiftshanteraren!");
        // ➕ Lägga till nya uppgifter i kön (Enqueue).
        Console.WriteLine("1. Lägg till uppgifter");
        // 👀 Visa nästa uppgift utan att ta bort den (Peek).
        Console.WriteLine("2. Visa nästa uppgift");
        // ✅ Slutföra en uppgift – ta bort den översta (Dequeue) och visa vilken som slutförts.
        Console.WriteLine("3. Slutför den översta uppgiften");
        // 📋 Visa alla återstående uppgifter i kön.
        Console.WriteLine("4. Visa dem kvarstående uppgifterna");

        Console.WriteLine("5. Avsluta");

        string val = Console.ReadLine()!;

        switch (val)
        {
            case "1":
                Console.WriteLine("Skriv uppgiften");
                string ny = Console.ReadLine()!;
                uppgifter.Enqueue(ny);
                Console.WriteLine($"{ny} lades till i kön.");
                break;

            case "2":
                if (uppgifter.Count > 0)
                    Console.WriteLine($"Nästa uppgift: {uppgifter.Peek()}");
                else
                    Console.WriteLine("Inga uppgifter i kön");
                break;

            case "3":
                if (uppgifter.Count > 0)
                {
                    string klar = uppgifter.Dequeue();
                    Console.WriteLine($"Slutfört: {klar}");
                }
                else
                {
                    Console.WriteLine("Inga uppgifter i kön");
                }
                break;

            case "4":
                if (uppgifter.Count > 0)
                {
                    Console.WriteLine("Återstående uppgifter:");
                    foreach (string uppgift in uppgifter)
                    {
                        Console.WriteLine($"- {uppgift}");
                    }
                }
                else
                {
                    Console.WriteLine("Inga uppgifter i kön");
                }
                break;

            case "5":
                KeepRunning = false;
                Console.WriteLine("Programmet avslutas.");
                break;

            default:
                Console.WriteLine("Ogiltigt val.");
                break;
        }

        // 💡 Tips:
        // Använd while (queue.Count > 0) för att visa alla.
        // Förklara skillnaden mellan Peek() och Dequeue().

        }
    }
    
}    

