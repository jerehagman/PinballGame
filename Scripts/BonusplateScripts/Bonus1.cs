using UnityEngine;
using System.Collections;

public class Bonus1 : MonoBehaviour
{
    public int BonusMultiplier = 1;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            //Destroy(gameObject);

            BonusMultiplier++;
            ScoreManager.score *= BonusMultiplier;
        }
    }
}
