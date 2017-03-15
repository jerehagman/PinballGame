using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopulateScrollView : MonoBehaviour {

    Text highscoreText;

	// Use this for initialization
	void Start () {
        highscoreText = GetComponent<Text>();

        highscoreText.text = 
          "1st:  " + LivesManager.highScore1.ToString() + "\n"
        + "2nd: " + LivesManager.highScore2.ToString() + "\n"
        + "3rd:  " + LivesManager.highScore3.ToString() + "\n"
        + "4th:  " + LivesManager.highScore4.ToString() + "\n"
        + "5th:  " + LivesManager.highScore5.ToString() + "\n"
        + "6th:  " + LivesManager.highScore6.ToString() + "\n"
        + "7th:  " + LivesManager.highScore7.ToString() + "\n"
        + "8th:  " + LivesManager.highScore8.ToString() + "\n"
        + "9th:  " + LivesManager.highScore9.ToString() + "\n"
        + "10th: " + LivesManager.highScore10.ToString() + "\n";
    }

	// Update is called once per frame
	void Update () {

	}
}
