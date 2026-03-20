using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private static Random rand = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string w in wordArray)
        {
            words.Add(new Word(w));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference.GetReferenceString());

        foreach (Word word in words)
        {
            Console.Write(word.Display() + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("Progress: " + GetHiddenCount() + "/" + words.Count + " words hidden");
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int hidden = 0;

        while (hidden < count && visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            hidden++;
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    private int GetHiddenCount()
    {
        int count = 0;

        foreach (Word word in words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }
}