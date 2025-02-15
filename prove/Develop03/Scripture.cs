using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture{
    public Refrence Refrence {get; }
    public List<Word> Words {get;}

    public Scripture(Refrence refrence, string text){

        Refrence = refrence; 
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count){

        Random random = new Random();
        for (int i = 0; i < count; i++){
            var notHiddenWords = Words.Where(w => !w.Hidden).ToList();
            if (notHiddenWords.Any()){
                int index = random.Next(notHiddenWords.Count);
                notHiddenWords[index].Hide();
            }
            else {
               break; 
            }
        }
    }

    public bool AllWordsHidden() => Words.All(word => word.Hidden);
    public override string ToString() => $"{Refrence}\n{string.Join(" ", Words)}";
}