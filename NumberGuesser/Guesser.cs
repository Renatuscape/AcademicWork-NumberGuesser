namespace NumberGuesser
{
    internal static class Guesser
    {
        public static void Guess(ref int guesses, Random random, ref int highestNumber, ref int lowestNumber)
        {
            if (guesses > 10)
            {
                Printer.PrintText("Hey, that was ten guesses! Sure you aren't lying?");
                Printer.PrintText("You can bite my shiny metal a**!");
                Environment.Exit(0);
            }
            int guess = random.Next(lowestNumber, highestNumber);
            Printer.PrintText($"Guess #{guesses}: {guess}");
            Printer.PrintText($" - [H] My number is higher");
            Printer.PrintText($" - [L] My number is lower");
            Printer.PrintText($" - [C] That's my number!");
            Console.Write("\t");
            string? userInput = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();

            if (userInput != null)
            {
                userInput = userInput.ToLower();
                if (userInput == "h")
                {
                    lowestNumber = guess + 1;
                    guesses++;
                    Guess(ref guesses, random, ref highestNumber, ref lowestNumber);
                }
                else if (userInput == "l")
                {
                    highestNumber = guess - 1;
                    guesses++;
                    Guess(ref guesses, random, ref highestNumber, ref lowestNumber);
                }
                else if (userInput == "c")
                {
                    Console.WriteLine(@"
  _________________________________
 |.--------_--_---------------__--.|
 ||    /\ |_)|_)|   /\ | |(_ |_   ||
 ;;`,_/``\|__|__|__/``\|_| _)|__ ,:|
((_(-,-----------.-.----------.-.)`)
 \__ )        ,'     `.        \ _/
 :  :        |_________|       :  :
 |-'|       ,'-.-.--.-.`.      |`-|
 |_.|      (( (*  )(*  )))     |._|
 |  |       `.-`-'--`-'.'      |  |
 |-'|        | ,-.-.-. |       |._|
 |  |        |(|-|-|-|)|       |  |
 :,':        |_`-'-'-'_|       ;`.;
  \  \     ,'           `.    /._/
   \/ `._ /_______________\_,'  /
    \  / :   ___________   : \,'
     `.| |  |           |  |,'
       `.|  |           |  |
         |  | SSt       |  |
");
                }
                else
                {
                    Printer.PrintText("That's not valid input. No cheating!");
                    Guess(ref guesses, random, ref highestNumber, ref lowestNumber);
                }
            }

        }
    }
}