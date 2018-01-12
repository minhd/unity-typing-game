using UnityEngine;

public class WordGenerator {
    private static string[] wordList = {
        "winter", "staircase", "embrace", "appetite", "conceive", "democratic", "dull", "flexible", "means", "dose",
        "population", "computing", "reality", "worm", "expenditure", "level", "manual", "community", "recognize",
        "characteristic", "behavior", "fashionable", "acquisition", "time", "count", "push", "exclude", "studio",
        "digital", "evening", "plane", "designer", "eaux", "bother", "danger", "fat", "qualified", "blackmail",
        "railroad", "build", "affect", "tank", "pleasant", "draft", "firefighter", "spy", "facility", "basket", "nose",
        "pour",
    };

    public static string GetRandomWord() {
        var randomIndex = Random.Range(0, wordList.Length - 1);
        return wordList[randomIndex];
    }
}