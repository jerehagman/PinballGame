using UnityEngine;
using System.Collections;

public class FlipperScript : MonoBehaviour {

    bool isActive = false;

    HingeJoint myJoint;

	// Use this for initialization
	void Start () {
        myJoint = GetComponent<HingeJoint>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
        if(Input.GetKey(KeyCode.LeftArrow) && isActive == false)
        {
            isActive = true;
            
            JointSpring spring = myJoint.spring;
            spring.targetPosition = -25;

            myJoint.spring = spring;

            GetComponent<AudioSource>().Play();
        }
        else if(Input.GetKey(KeyCode.LeftArrow) == false && isActive == true)
        {
            isActive = false;

            JointSpring spring = myJoint.spring;
            spring.targetPosition = 20;

            myJoint.spring = spring;

        }
	}
}
