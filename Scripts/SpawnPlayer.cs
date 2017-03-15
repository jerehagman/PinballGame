using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnPlayer : MonoBehaviour {


    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (col.gameObject.tag == "Player")
        {
            player.transform.position = new Vector3(10.732f, 0.6059407f, 1.277f);

            GetComponent<AudioSource>().Play();

            LivesManager.currentLives--;

        }
    }
}
