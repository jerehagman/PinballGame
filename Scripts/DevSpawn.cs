using UnityEngine;
using System.Collections;

public class DevSpawn : MonoBehaviour {


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (Input.GetKey(KeyCode.F1))
        {
            player.transform.position = new Vector3(11.086f, 0.5759407f, 1.966f);
        }
    }
}
