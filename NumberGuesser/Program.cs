namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0;
            Random random = new Random();
            int highestNumber = 1001;
            int lowestNumber = 1;

            Printer.PrintText("*** Number Guesser ***");
            Printer.PrintText("Think of a number between 1 and 1000, and I'll guess it in just ten tries!\n\tWhen you are ready, press any button!", false);
            Console.ReadLine();

            Guesser.Guess(ref guesses, random, ref highestNumber, ref lowestNumber);
        }
    }
}