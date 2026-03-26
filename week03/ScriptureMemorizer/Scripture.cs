public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string w in wordArray)
        {
            _words.Add(new Word(w));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetReferenceString());

        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("Progress: " + GetHiddenCount() + "/" + _words.Count + " words hidden");
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int hidden = 0;

        while (hidden < count && visibleWords.Count > 0)
        {
            int index = _rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            hidden++;
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in _words)
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

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }
}