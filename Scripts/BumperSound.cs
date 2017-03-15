using UnityEngine;
using System.Collections;

public class BumperSound : MonoBehaviour {

    //Volume: 0..1
    //Magnitude

    private void OnCollisionStay(Collision col)
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
    }

}
