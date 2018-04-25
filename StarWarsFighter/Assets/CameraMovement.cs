using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform target;
    private Camera cam;
    private Vector3 currentVelocity;
    float smoothTime = 0.01f;
    float rotSpeed = 0;
    public float rotMulip = 0.05f;

    float maxSpeed;

    // Use this for initialization
    void Start () {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void FixedUpdate()
    {
        //smoothTime = 1 / Vector3.Distance(target.position, transform.position);
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref currentVelocity, smoothTime, maxSpeed = Mathf.Infinity);

        //transform.rotation = target.transform.rotation;

        rotSpeed = Quaternion.Angle(target.rotation, transform.rotation) * rotMulip;
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(target.rotation.x, target.rotation.y, target.rotation.z), rotSpeed);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation ,rotSpeed);

    }
}
