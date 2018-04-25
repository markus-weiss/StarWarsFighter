using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour {


    /*
    float speed = 0;
    float boost = 0.1f;
    float speedMax = 1;
    float speedMin = 0;
    float RotationSpeed = 2;
    */

    public float speed = 0;
    public float boost = 1;
    public float speedMax = 50;
    public float speedMin = 0;
    public float RotationSpeed = 2;


    /*
    public float cameraSensitivity = 90;
    public float climbSpeed = 4;
    public float normalMoveSpeed = 10;
    public float slowMoveFactor = 0.25f;
    public float fastMoveFactor = 3;


    private float rotationX = 0.0f;
    private float rotationY = 0.0f;
    */
    Rigidbody rigidbody;
    private float rotateAroundForward = 0.1f;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update () {
        
        if (Input.GetKey(KeyCode.W))
        {
            if(speed < speedMax)
            {
                speed += boost;
            }
            else if (speed > speedMax)
            {
                speed = speedMax;
            }
            rigidbody.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (speed > speedMin)
            {
                speed -= boost;
            }
            else if (speed < speedMin)
            {
                speed = speedMin;
            }
            rigidbody.AddForce(transform.forward * speed);
        }
        Debug.Log(speed);



        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, 20 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, -20 * Time.deltaTime);
        }


        
        transform.position += Vector3.forward * speed * Time.deltaTime;

        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.position), Time.fixedDeltaTime * 10);
        //rigidbody.velocity = transform.TransformDirection(Input.GetAxis("Mouse Y"),0,0) * speed;



        //transform.RotateAround(Vector3.zero, Vector3.right, Input.GetAxis("Mouse Y") * 10 * Time.deltaTime);

        //transform.rotation += Vector3.forward * Input.GetAxis("Mouse Y") *10 * Time.deltaTime); 

        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);

        //transform.RotateAround(Vector3.zero, Vector3.right, Input.GetAxis("Mouse Y") *10* Time.deltaTime);

        //transform.RotateAround(Vector3.zero, Vector3.right, Input.GetAxis("Mouse X") *10* Time.deltaTime);

        /*
        float h = 100 * Input.GetAxis("Mouse X");
        float v = 100 * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
        */


        /*
        Debug.Log(speed);

        rotationX += Input.GetAxis("Mouse X") * cameraSensitivity * Time.deltaTime;
        rotationY += Input.GetAxis("Mouse Y") * cameraSensitivity * Time.deltaTime;
        rotationY = Mathf.Clamp(rotationY, -90, 90);

        transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
        transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            transform.position += transform.forward * (normalMoveSpeed * fastMoveFactor) * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.position += transform.right * (normalMoveSpeed * fastMoveFactor) * Input.GetAxis("Horizontal") * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            transform.position += transform.forward * (normalMoveSpeed * slowMoveFactor) * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.position += transform.right * (normalMoveSpeed * slowMoveFactor) * Input.GetAxis("Horizontal") * Time.deltaTime;
        }
        else
        {
            transform.position += transform.forward * normalMoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.position += transform.right * normalMoveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.Q)) { transform.position += transform.up * climbSpeed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.E)) { transform.position -= transform.up * climbSpeed * Time.deltaTime; }

        if (Input.GetKeyDown(KeyCode.End))
        {
            Screen.lockCursor = (Screen.lockCursor == false) ? true : false;
        }
        //transform.Rotate((Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), (Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime), 0, Space.World);
        */
    }
}
