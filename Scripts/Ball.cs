using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    Rigidbody rb;
    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        if(rb.velocity.x > 10)
        {
            
        }
        rb.maxAngularVelocity = Mathf.Infinity;
	}
	
	// Update is called once per frame
	void Update () {

	}

   /* private void OnTriggerEnter(Collider other)
    {
        GameObject bonusplate;
        if(other.gameObject.tag == "bonus")
        {
            bonusplate = GameObject.FindWithTag("bonus");
            Destroy(bonusplate);

        }
    }*/
    private void OnCollisionEnter(Collision col)
    {
        GameObject bonusplate1;
        GameObject bonusplate2;
        GameObject bonusplate3;

        bonusplate1 = GameObject.Find("bonus1");
        bonusplate2 = GameObject.Find("bonus2");
        bonusplate3 = GameObject.Find("bonus3");

        if (col.gameObject.name == "bonus1")
        {
            bonusplate1.GetComponent<MeshRenderer>().enabled = false;

        }
        if (col.gameObject.name == "bonus2")
        {
            bonusplate2.GetComponent<MeshRenderer>().enabled = false;

        }
        if (col.gameObject.name == "bonus3")
        {
            bonusplate3.GetComponent<MeshRenderer>().enabled = false;

        }
    }
}
