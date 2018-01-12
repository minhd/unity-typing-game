[System.Serializable]
public class Word {
    public string word;
    private int typeIndex;
    WordDisplay display;

    public Word(string word, WordDisplay display) {
        this.display = display;
        this.word = word;
        typeIndex = 0;
        this.display.setWord(this.word);
    }

    public char getNextLetter() {
        return word[typeIndex];
    }

    public void typeLetter() {
        typeIndex++;
        display.RemoveLetter();
    }

    public bool wordTyped() {
        bool typed =  typeIndex >= word.Length - 1;
        if (typed) {
            display.RemoveWord();
        }
        return typed;
    }
}