public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;
    private bool hasRange;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verse;
        this.hasRange = false;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
        this.hasRange = true;
    }

    public string GetReferenceString()
    {
        if (hasRange)
        {
            return book + " " + chapter + ":" + verseStart + "-" + verseEnd;
        }
        else
        {
            return book + " " + chapter + ":" + verseStart;
        }
    }
}