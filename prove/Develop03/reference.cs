public class Reference {
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;
    private string _reference;
    private string _verseText;

    public Reference(string book, int chapter, int firstVerse, string text){
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _reference = _book + " " + _chapter + ":" + _firstVerse + " ";
        _verseText = text;
    }

    public Reference(string book, int chapter, int firstVerse, int lastVerse, string text){
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
        _reference = _book + " " + _chapter + ":" + _firstVerse + " - " + _lastVerse + " ";
        _verseText = text;
    }

    public string GetReference(){
        return _reference;
    }
    
    public string GetVerseText(){
        return _verseText;
    }
}
