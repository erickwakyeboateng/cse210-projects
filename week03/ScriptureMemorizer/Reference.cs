public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private bool _hasRange;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _hasRange = false;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _hasRange = true;
    }

    public string GetReferenceString()
    {
        if (_hasRange)
        {
            return _book + " " + _chapter + ":" + _verseStart + "-" + _verseEnd;
        }
        else
        {
            return _book + " " + _chapter + ":" + _verseStart;
        }
    }
}