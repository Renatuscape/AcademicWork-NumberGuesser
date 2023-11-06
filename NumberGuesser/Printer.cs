namespace NumberGuesser
{
    internal static class Printer
    {

        public static void PrintText(string text, bool lineBreak = true)
        {
            var toPrint = "\t" + text;

            for (int i = 0; i < toPrint.Length; i++)
            {
                Console.Write(toPrint[i]);
                Thread.Sleep(10); // Sleep for 150 milliseconds
            }

            if (lineBreak)
            {
                Console.WriteLine();
            }
        }
    }
}