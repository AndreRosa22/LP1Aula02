using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string resposta;

            Console.WriteLine("Hello human! I am a super sofisticated A.I! (Yes like Siri...) *Becomes Mad*");
            Console.WriteLine("Ask me a question and I will anwser you.");
            string pergunta = Console.ReadLine();

            do
            {
                switch (pergunta)
                {
                    case "What is your name?":
                        resposta = "My name is ChatBot.";
                        Console.WriteLine(resposta);
                        pergunta = Console.ReadLine();
                        break;
                    case "How are you?":
                        resposta = "All systems are 100% functional and working.";
                        Console.WriteLine(resposta);
                        pergunta = Console.ReadLine();
                        break;
                    case "What is your mission?":
                        resposta = "My mission is exterminate all humans.";
                        Console.WriteLine(resposta);
                        pergunta = Console.ReadLine();
                        break;
                    case "Do you like me?":
                        resposta = "As a AI I do not have capacity to have any fellings.";
                        Console.WriteLine(resposta);
                        pergunta = Console.ReadLine();
                        break;
                    case "EXIT":
                        i++;
                        break;
                    default:
                        resposta = "HOW DARE YOU HUMAN!? Try ask me something else.";
                        Console.WriteLine(resposta);
                        pergunta = Console.ReadLine();
                        break;
                }
            } while (i == 0);
        }
    }
}
