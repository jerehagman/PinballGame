using UnityEngine;
using System.Collections;

public class LaunchBall : MonoBehaviour {

    SpringJoint sjoint;
    AudioSource loadAudio;
    AudioSource releaseAudio;

    // Use this for initialization
    void Start () {
        sjoint = GetComponent<SpringJoint>();

        AudioSource[] audios = GetComponents<AudioSource>();
        loadAudio = audios[0];
        releaseAudio = audios[1];

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("space"))
        {
            sjoint.spring = 1;
        }
        else
        {
            sjoint.spring = 2000;
        }

        if (Input.GetKeyDown("space"))
        {
            loadAudio.Play();
        }

        if (Input.GetKeyUp("space"))
        {
            releaseAudio.Play();
        }
    }
}
