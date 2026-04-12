using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Updated Security-Based Name
            string botName = "CyberSentinel"; 
            bool keepRunning = true;

            // UI Header
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("#################################################");
            Console.WriteLine($"##        {botName.ToUpper()} SECURITY PROTOCOL        ##");
            Console.WriteLine("#################################################");
            Console.ResetColor();

            Console.WriteLine($"\n[{DateTime.Now:HH:mm}] System: Connection established.");
            Console.WriteLine($"{botName}: Standing by. I can assist with Phishing, Passwords, or Link Safety.");
            Console.WriteLine("(Type 'terminate' to end the session)\n");

            while (keepRunning)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("User_Query> ");
                string userInput = Console.ReadLine()?.ToLower() ?? "";

                if (userInput == "terminate" || userInput == "exit")
                {
                    keepRunning = false;
                    Console.WriteLine($"\n{botName}: Session ended. Stay vigilant.");
                }
                else
                {
                    string response = GetBotResponse(userInput);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{botName}: {response}");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }

        static string GetBotResponse(string input)
        {
            if (input.Contains("phishing") || input.Contains("scam"))
            {
                return "THREAT ALERT: Phishing is a common attack in SA. \n" +
                       "Advice: Do not trust 'Urgent' emails from banks asking for your PIN.";
            }
            else if (input.Contains("password"))
            {
                return "SECURITY BEST PRACTICE: Avoid using names or birthdays. \n" +
                       "Advice: Use a passphrase like 'Blue-Mountain-Elephant-2026' for high entropy.";
            }
            else if (input.Contains("link") || input.Contains("url"))
            {
                return "PROTOCOL: Treat all shortened links (bit.ly/tinyurl) as suspicious. \n" +
                       "Advice: Use a URL scanner before clicking if the source is unknown.";
            }
            else
            {
                return "I do not recognize that query. Please specify a security domain (e.g., Passwords).";
            }
        }
    }
}