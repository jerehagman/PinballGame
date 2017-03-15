using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{

    public static int currentLives;
    bool played;
    TextMesh text;
    public static int yourScore;
    public static int highScore1;
    public static int highScore2;
    public static int highScore3;
    public static int highScore4;
    public static int highScore5;
    public static int highScore6;
    public static int highScore7;
    public static int highScore8;
    public static int highScore9;
    public static int highScore10;

    void Start()
    {
        highScore1 = PlayerPrefs.GetInt("HighScore1");
        highScore2 = PlayerPrefs.GetInt("HighScore2");
        highScore3 = PlayerPrefs.GetInt("HighScore3");
        highScore4 = PlayerPrefs.GetInt("HighScore4");
        highScore5 = PlayerPrefs.GetInt("HighScore5");
        highScore6 = PlayerPrefs.GetInt("HighScore6");
        highScore7 = PlayerPrefs.GetInt("HighScore7");
        highScore8 = PlayerPrefs.GetInt("HighScore8");
        highScore9 = PlayerPrefs.GetInt("HighScore9");
        highScore10 = PlayerPrefs.GetInt("HighScore10");

        Debug.Log("#1 : " + highScore1);
        Debug.Log("#2 : " + highScore2);
        Debug.Log("#3 : " + highScore3);
        Debug.Log("#4 : " + highScore4);
        Debug.Log("#5 : " + highScore5);
        Debug.Log("#6 : " + highScore6);
        Debug.Log("#7 : " + highScore7);
        Debug.Log("#8 : " + highScore8);
        Debug.Log("#9 : " + highScore9);
        Debug.Log("#10 : " + highScore10);

    }

    void Awake()
    {
        played = false;
        text = GetComponent<TextMesh>();
        currentLives = 3;
    }

    void Update()
    {
        setLivesText();

        if (text.text == "GAME OVER" && !played)
        {
            //GetComponent<AudioSource>().Play();
            played = true;

            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
        }
    }

    void setLivesText()
    {
        text.text = "Lives:    " + currentLives.ToString();

        if (currentLives <= 0)
        {
            text.text = "GAME OVER";
            yourScore = ScoreManager.score;

            //Pirusti highscore logiikka koodia

            //  HIGHSCORE #1
            if (highScore1 < yourScore)
            {
                PlayerPrefs.SetInt("HighScore1", yourScore);
                PlayerPrefs.SetInt("HighScore2", highScore1);
                PlayerPrefs.SetInt("HighScore3", highScore2);
                PlayerPrefs.SetInt("HighScore4", highScore3);
                PlayerPrefs.SetInt("HighScore5", highScore4);
                PlayerPrefs.SetInt("HighScore6", highScore5);
                PlayerPrefs.SetInt("HighScore7", highScore6);
                PlayerPrefs.SetInt("HighScore8", highScore7);
                PlayerPrefs.SetInt("HighScore9", highScore8);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #2
            if (highScore2 < yourScore && highScore1 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore2", yourScore);
                PlayerPrefs.SetInt("HighScore3", highScore2);
                PlayerPrefs.SetInt("HighScore4", highScore3);
                PlayerPrefs.SetInt("HighScore5", highScore4);
                PlayerPrefs.SetInt("HighScore6", highScore5);
                PlayerPrefs.SetInt("HighScore7", highScore6);
                PlayerPrefs.SetInt("HighScore8", highScore7);
                PlayerPrefs.SetInt("HighScore9", highScore8);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #3
            if (highScore3 < yourScore && highScore2 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore3", yourScore);
                PlayerPrefs.SetInt("HighScore4", highScore3);
                PlayerPrefs.SetInt("HighScore5", highScore4);
                PlayerPrefs.SetInt("HighScore6", highScore5);
                PlayerPrefs.SetInt("HighScore7", highScore6);
                PlayerPrefs.SetInt("HighScore8", highScore7);
                PlayerPrefs.SetInt("HighScore9", highScore8);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #4
            if (highScore4 < yourScore && highScore3 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore4", yourScore);
                PlayerPrefs.SetInt("HighScore5", highScore4);
                PlayerPrefs.SetInt("HighScore6", highScore5);
                PlayerPrefs.SetInt("HighScore7", highScore6);
                PlayerPrefs.SetInt("HighScore8", highScore7);
                PlayerPrefs.SetInt("HighScore9", highScore8);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #5
            if (highScore5 < yourScore && highScore4 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore5", yourScore);
                PlayerPrefs.SetInt("HighScore6", highScore5);
                PlayerPrefs.SetInt("HighScore7", highScore6);
                PlayerPrefs.SetInt("HighScore8", highScore7);
                PlayerPrefs.SetInt("HighScore9", highScore8);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #6
            if (highScore6 < yourScore && highScore5 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore6", yourScore);
                PlayerPrefs.SetInt("HighScore7", highScore6);
                PlayerPrefs.SetInt("HighScore8", highScore7);
                PlayerPrefs.SetInt("HighScore9", highScore8);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #7
            if (highScore7 < yourScore && highScore6 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore7", yourScore);
                PlayerPrefs.SetInt("HighScore8", highScore7);
                PlayerPrefs.SetInt("HighScore9", highScore8);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #8
            if (highScore8 < yourScore && highScore7 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore8", yourScore);
                PlayerPrefs.SetInt("HighScore9", highScore8);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #9
            if (highScore9 < yourScore && highScore8 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore9", yourScore);
                PlayerPrefs.SetInt("HighScore10", highScore9);
            }

            //  HIGHSCORE #10
            if (highScore10 < yourScore && highScore9 >= yourScore)
            {
                PlayerPrefs.SetInt("HighScore10", yourScore);
            }

        }
    }
}
