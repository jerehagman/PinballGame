using UnityEngine;
using System.Collections;

public class LightCollision2 : MonoBehaviour {

    public Light myLight;
    // Use this for initialization
    void Start()
    {
        GameObject light = GameObject.Find("Cylinder2");
        myLight = light.GetComponent<Light>();
        myLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator lightCollide()
    {
        myLight.enabled = true;
        yield return new WaitForSeconds(0.3f);
        myLight.enabled = false;

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(lightCollide());
        }
    }
}
