/*  EXCEEDING REQUIREMENTS:
    - Added a library of multiple scriptures and randomly selects one each time the program runs.
    - Improved word hiding so that only words that are not already hidden are selected.
    - Added a progress tracker to show how many words have been hidden.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>();

        scriptureLibrary.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        ));

        scriptureLibrary.Add(new Scripture(
            new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God."
        ));

        scriptureLibrary.Add(new Scripture(
            new Reference("Alma", 37, 6),
            "By small and simple things are great things brought to pass."
        ));

        scriptureLibrary.Add(new Scripture(
            new Reference("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness I give unto men weakness that they may be humble."
        ));

        Random rand = new Random();
        int index = rand.Next(scriptureLibrary.Count);
        Scripture scripture = scriptureLibrary[index];

        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.IsFullyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}