using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {
    public List<Word> words;
    [SerializeField] private Word activeWord;
    [SerializeField] private bool hasActiveWord;

    public WordSpawner wordSpawner;

    private void Start() {
        AddWord();
        AddWord();
        AddWord();
    }

    public void AddWord() {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        words.Add(word);
    }

    public void TypeLetter(char letter) {
        if (hasActiveWord) {
            if (activeWord.getNextLetter() == letter) {
                activeWord.typeLetter();
            }
        }
        else {
            foreach (Word word in words) {
                if (word.getNextLetter() == letter) {
                    activeWord = word;
                    hasActiveWord = true;
                    word.typeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.wordTyped()) {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}