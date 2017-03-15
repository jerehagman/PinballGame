using UnityEngine;
using System.Collections;

public class GlowScript : MonoBehaviour {

    public int scoreValue = 150;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter(Collider other)
    {
        Behaviour h = (Behaviour)GetComponent("Halo");
        Light l = (Light)GetComponent("Light");
        if (other.gameObject.tag == "Player")
        {
            h.enabled = true;
            l.enabled = true;
            GetComponent<AudioSource>().Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Behaviour h = (Behaviour)GetComponent("Halo");
        Light l = (Light)GetComponent("Light");
        if (other.gameObject.tag == "Player")
        {
            h.enabled = false;
            l.enabled = false;
            ScoreManager.score += scoreValue;
        }
    }
}

