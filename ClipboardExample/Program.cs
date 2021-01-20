using System;


namespace ClipboardExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TextCopy.ClipboardService.SetText("Text to place in clipboard");

            Console.WriteLine("Copied!");
            Console.ReadKey();
        }
    }
}
