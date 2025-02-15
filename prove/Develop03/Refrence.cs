public class Refrence{

    public string Book {get; }
    public string Chapter {get; }
    public string Verse {get; }

    public Refrence(string book, string chapter, string verse){

        Book = book;
        Chapter = chapter; 
        Verse = verse;
    }

    public override string ToString() => $"{Book} {Chapter}:{Verse}";
}