public class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public string Display()
    {
        if (hidden)
        {
            string result = "";

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    result += "_";
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
        else
        {
            return text;
        }
    }
}