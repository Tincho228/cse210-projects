public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Library _myLibrary = new Library();
    private Reference _myReference;

    public Scripture()
    {
        _myReference = _myLibrary.GetReferenceGenerator();
        string verseText = _myReference.GetVerseText();
        string[] parts = verseText.Split(" ");
        foreach (string part in parts){
            Word word = new Word(part, true);
            _words.Add(word);
        }
    }

    public void SetHideWords()
    {
        int visibleWords = CountVisibleWords();
        int count = 0;
        while ((count < 3) && (count < visibleWords)){
            Random random = new Random();
            int rand_number = random.Next(0,_words.Count());
            if(_words[rand_number].GetVisibility() == true){
                _words[rand_number].SetHiddenText();
                count += 1;
            }
        }
    }

    public int CountVisibleWords()
    {
        int visibleWords = 0;
        foreach (Word word in _words)
        {
            if(word.GetVisibility() == true)
            {
                visibleWords +=1;
            }
        }
        return visibleWords;
    }

    public void GetRenderedScripture()
    {
        Console.Write(_myReference.GetReference());
        foreach(Word word in _words){
            Console.Write(word.GetRenderedWord()+" ");
        }
        Console.WriteLine("\n");
    }

}