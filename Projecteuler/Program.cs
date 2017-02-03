using System;

namespace Projecteuler
{
    class Program
    {

        private bool running = true;

        static void Main(string[] args)
        {
            Program p = new Program();

            p.Run();
        }

        private void Run()
        {
            while (running) { 
                Menu.PrintMenu();
                SelectOption(Console.ReadLine());
                Console.ReadKey();
                Console.Clear(); 
            }
        }

        private void SelectOption(string option)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            switch (option) {
                case "1":
                    Console.WriteLine(new Ex01().GetCalculatedSum());
                    break;
                case "2":
                    Console.WriteLine(new Ex02().GetCalculatedSum());
                    break;
                case "3":
                    Console.WriteLine("Well that excalated quickly");
                    //Console.WriteLine(new Ex03().GetCalculatedSum());
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Incorrect input, try again.");
                    break;
            }
            Console.WriteLine("------------------------------------------------");
        }
    }
}
