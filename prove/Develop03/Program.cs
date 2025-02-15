using System;

class Program
{
    static void Main(string[] args)
    {
       Refrence refrence = new Refrence("John", "3", "16");
       Scripture scripture = new Scripture(refrence, " For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (!scripture.AllWordsHidden()){

            Console.Clear();
            Console.WriteLine(scripture);

            Console.WriteLine("\nPress enter to hide words or type 'quit':");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit"){
                break;
            }

            scripture.HideRandomWords(2);
        }

        Console.WriteLine("\nAll words hidden. Program finished.");
    }
}
