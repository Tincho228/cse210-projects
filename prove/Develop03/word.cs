public class Word{
    private string _text;
    private bool _visibility;

    public Word(string text, bool visibility) {
        _text = text;
        _visibility = visibility;
    }

    public string GetRenderedWord()
    {
        return _text; 
    }

    public bool GetVisibility()
    {
        return _visibility;
    }
    
    public void SetHiddenText(){
        _visibility = false;
        string hiddenWord = "";
        foreach (char letter in _text){
            hiddenWord = hiddenWord + "_";
        }
        _text = hiddenWord;
    }
}