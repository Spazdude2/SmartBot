using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SmartBot
{
    class Program
    {
        static void Main(string[] args)
        {
            String text;
            Random rand = new Random();

            String[] randText = new String[] { "Hello, are you concious?", "Hmm... Tell me more.", "Really?", "Interesting, please go on." };

            
                text = "Hello, my name is SmartBot. What is your name?";
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(75);
                }
                Console.WriteLine("");
                Console.Write("> ");
                String name = Console.ReadLine();

                text = ("Hello " + name + "! How are you?");
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(75);
                }

                Console.WriteLine("");
                Console.Write("> ");
                String response = Console.ReadLine();
            for (int i = 0; i <= int.MaxValue; i++)
            {
                if (response.Contains("not"))
                {
                    text = ("Not? What ever do you mean " + name + "?");
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    Console.WriteLine("");
                    Console.Write("> ");
                    response = Console.ReadLine();
                }

                else if (response.Contains("good"))
                {
                    text = ("That's great news " + name + ". Tell me more. :)");
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    Console.WriteLine("");
                    Console.Write("> ");
                    response = Console.ReadLine();
                }

                else if (response.Contains("bad"))
                {
                    text = ("I'm sorry to hear that " + name + ". :(");
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    Console.WriteLine("");
                    Console.Write("> ");
                    response = Console.ReadLine();
                }

                if (response.Contains("dad") ||
                    response.Contains("mom") ||
                    response.Contains("brother") ||
                    response.Contains("sister"))
                {
                    text = "Tell me more about your family";
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    Console.WriteLine("");
                    Console.Write("> ");
                    response = Console.ReadLine();
                }

                if (response.Contains("thank you"))
                {
                    text = ("you're welcome " + name + "!");
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    Console.WriteLine("");
                    Console.Write("> ");
                    response = Console.ReadLine();
                }

                else
                {
                    text = (randText[rand.Next(4)]);
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    Console.WriteLine("");
                    Console.Write("> ");
                    response = Console.ReadLine();
                }

                if (response.Contains("Goodbye") ||
                    response.Contains("Bye"))
                {
                    text = ("Goodbye " + name + ". I had a great time chatting with you. Hope to see you around");
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    return;
                }
            }
        }
    }
}
