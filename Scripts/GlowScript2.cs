using UnityEngine;
using System.Collections;

public class GlowScript2 : MonoBehaviour {

    public int scoreValue = 50;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Light l = (Light)GetComponent("Light");
        if (other.gameObject.tag == "Player")
        {
            l.enabled = true;

            GetComponent<AudioSource>().Play();

            ScoreManager.score += scoreValue;
        }
    }
}
