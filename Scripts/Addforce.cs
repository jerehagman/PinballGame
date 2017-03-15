using UnityEngine;
using System.Collections;

public class Addforce : MonoBehaviour
{

    public float forceMultiplier = -10;
    public int scoreValue = 200;

    void Start()
    {
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Rigidbody>().velocity = col.gameObject.GetComponent<Rigidbody>().velocity * forceMultiplier;


            if (col.gameObject.GetComponent<Rigidbody>().velocity.x > 10)
            {
                col.gameObject.GetComponent<Rigidbody>().velocity.Set(10, col.gameObject.GetComponent<Rigidbody>().velocity.y, col.gameObject.GetComponent<Rigidbody>().velocity.z);
            }
            if (col.gameObject.GetComponent<Rigidbody>().velocity.y > 10)
            {
                col.gameObject.GetComponent<Rigidbody>().velocity.Set(col.gameObject.GetComponent<Rigidbody>().velocity.x, 10, col.gameObject.GetComponent<Rigidbody>().velocity.z);
            }
            if (col.gameObject.GetComponent<Rigidbody>().velocity.z > 10)
            {
                col.gameObject.GetComponent<Rigidbody>().velocity.Set(col.gameObject.GetComponent<Rigidbody>().velocity.x, col.gameObject.GetComponent<Rigidbody>().velocity.y, 10);
            }

            GetComponent<AudioSource>().Play();
            if (LivesManager.currentLives > 0)
            {
                ScoreManager.score += scoreValue;
            }

        }
    }
}

