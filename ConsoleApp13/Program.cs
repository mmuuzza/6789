// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("1. Add a question\n2. Get Questions with answers\nFill in your choise: ");

            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    AddQuestion();
                    break;
                case "2":
                    GetQuestions();
                    break;
                default:
                    break;
            }
        }
    }

  