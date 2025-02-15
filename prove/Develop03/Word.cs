public class Word{
    public string Text {get; }
    public bool Hidden {get; private set; }

    public Word(string text){
        Text = text;
        Hidden = false;
    }

    public void Hide() => Hidden = true;
    public void Show() => Hidden = false;

    public override string ToString() => Hidden ? "___" : Text;
}