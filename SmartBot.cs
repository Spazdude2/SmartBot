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
            int ResponseLimit = 0;
            String text; //SmartBot
            

            String[] randText = new String[] {"Hmm... Tell me more.",
                "Try saying 'Be a Comedian'",
                "Really?",
                "Interesting, please go on.",
                "To end the conversation at anytime, say 'Goodbye'.",
                "What else is new?"};

            Random rand = new Random(randText.Length);

            
            text = "Hello, my name is SmartBot. What is your name?";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            Console.WriteLine("");
            Console.Write("> ");
            String name = Console.ReadLine(); //Reffers to you throughout conversation

            text = ("Hello " + name + "! How are you?");
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }

            Console.WriteLine("");
            Console.Write("> ");
            String response = Console.ReadLine(); //Everything else YOU say


            for (int i = 0; i <= ResponseLimit + 1; i++) //In a for loop for continuous conversation
            {
                
                ResponseLimit++;
                if (response.Contains("not"))
                {
                    ResponseLimit--;
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
                    ResponseLimit--;
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
                    ResponseLimit--;
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
                    ResponseLimit--;
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
                    ResponseLimit--;
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

                if (response.Contains("Goodbye") ||
                    response.Contains("Bye")) //Ending conversation with SmartBot
                {
                    text = ("Goodbye " + name + ". I had a great time chatting with you. Hope to see you around");
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    return; //End program
                }
//Entering Comedian Mode
                if (response.Contains("Be a Comedian"))
                {
                    int jokes = 11;
                    
                    String[] Jokes = new String[] { "What did one penny say to the other? \n \nLets get together and make cents. HAHA!",
                        " Why couldn't the blonde add 10 and 7 on a calculator? \n \nShe couldn't find the 10 key.",
                        "What do you call a blonde with 2 brain cells? \n \nPregnant.",
                        "Why did the tomato blush? \n \nBecause it saw the salad dressing."};

                    Random randJokes = new Random(Jokes.Length);
                  
                        text = ("Welcome " + name + ", to Comedian Mode. Fat people usually can't walk for the time it took you to get here, HA! Well any way, " + name + " when in Comedian Mode, you get to hear a random assortment of 10 jokes, when you run out of jokes you go back \n into Normal Mode");
                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(75);
                        }

                        Console.WriteLine("");
                        Console.Write("> ");
                        response = Console.ReadLine();
                        

                    for (int j = jokes; j >= 0; j--)
                    {
                        
                        jokes--;
                        if (jokes <= 0) //Once out of jokes, Comedian Mode shuts down
                        {
                            break; //How to get out of a for loop
                        }

                        if (response.Contains("Goodbye") ||
                            response.Contains("Bye")) //Ending conversation with SmartBot while in Comedian Mode
                        {
                            text = ("Goodbye " + name + ". I had a great time chatting with you. Hope to see you around");
                            foreach (char c in text)
                            {
                                Console.Write(c);
                                Thread.Sleep(75);
                            }

                            return; //End program
                        }


                        else
                        {
                            text = (Jokes[randJokes.Next(i + 1)]);
                            foreach (char c in text)
                            {
                                Console.Write(c);
                                Thread.Sleep(75);
                            }

                            Console.WriteLine("");
                            Console.Write("> ");
                            response = Console.ReadLine();
                        }
                    }
                }

                if (ResponseLimit >= 10)
                {
                    text = "TOO MUCH CONVERSATION. GOODBYE";
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }
                    return;
                }

//Anything that is not counted for in an if statement
                else
                {
                    text = (randText[rand.Next(i)]);
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(75);
                    }

                    Console.WriteLine("");
                    Console.Write("> ");
                    response = Console.ReadLine();
                    
                }
            }
        }
        
    }
}
