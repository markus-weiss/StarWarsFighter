using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserKanon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public Rigidbody projectile;

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(Vector3.forward * 200);
        }

    }
}
