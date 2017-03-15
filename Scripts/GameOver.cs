using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public Text livesText;
    bool played = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (livesText.text == "GAME OVER" && !played)
        {
            GetComponent<AudioSource>().Play();
            played = true;

        }
    }
}
