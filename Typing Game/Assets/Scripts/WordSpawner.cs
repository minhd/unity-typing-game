using UnityEngine;

public class WordSpawner : MonoBehaviour {
    public GameObject wordPrefab;
    public Transform canvas;

    public WordDisplay SpawnWord() {
        Vector3 randomPosition = new Vector3(Random.Range(-200.5f, 200.5f), 300f);
        GameObject wordObject = Instantiate(wordPrefab, randomPosition, Quaternion.identity, canvas);
        WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay>();
        return wordDisplay;
    }
}