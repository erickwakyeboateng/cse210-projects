public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string Display()
    {
        if (_hidden)
        {
            string result = "";

            foreach (char c in _text)
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
            return _text;
        }
    }
}