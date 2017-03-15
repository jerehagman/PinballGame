using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public static int score;
    TextMesh text;
	// Use this for initialization
	void Awake () {
        text = GetComponent<TextMesh>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        text.alignment = TextAlignment.Center;
        text.text = "Score\n" + score;
	}
}
