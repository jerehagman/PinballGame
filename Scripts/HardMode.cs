using UnityEngine;
using System.Collections;

public class HardMode : MonoBehaviour {

    public Vector3 cameraFollowOffset = new Vector3(0, 5, -5);
    public Camera mainCamera;
    public Camera followCamera;

    void Start()
    {
        mainCamera.enabled = true;
        followCamera.enabled = false;
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            mainCamera.enabled = !mainCamera.enabled;
            followCamera.enabled = !followCamera.enabled;
        }

        followCamera.transform.position = transform.position + cameraFollowOffset;
    }
}
