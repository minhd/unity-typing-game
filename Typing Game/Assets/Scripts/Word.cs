[System.Serializable]
public class Word {
    public string word;
    private int typeIndex;

    public Word(string word) {
        this.word = word;
        typeIndex = 0;
    }

    public char getNextLetter() {
        return word[typeIndex];
    }

    public void typeLetter() {
        typeIndex++;
        // remove the letter on screen
    }

    public bool wordTyped() {
        return typeIndex >= word.Length - 1;
    }
}