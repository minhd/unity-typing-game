using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {
    public Text text;

    float fallSpeed;

    public void Awake() {
        text = GetComponent<Text>();
        fallSpeed = Random.Range(20f, 50f);
    }

    public void setWord(string word) {
        text.text = word;
    }

    public void RemoveLetter() {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord() {
        Destroy(gameObject);
    }

    public void Update() {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }
}