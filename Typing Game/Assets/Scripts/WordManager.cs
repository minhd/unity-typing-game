using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {
    public List<Word> words;
    [SerializeField] public Word activeWord;
    [SerializeField] private bool hasActiveWord;

    private void Start() {
        AddWord();
        AddWord();
        AddWord();
    }

    private void AddWord() {
        Word word = new Word(WordGenerator.GetRandomWord());
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