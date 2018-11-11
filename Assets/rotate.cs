using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    private int speed = 50;
    public Rigidbody r_beam;
    void Update()
    {
        if (r_beam.isKinematic)
        {
            if (Input.GetKey("right"))
                transform.Rotate(Vector3.up, speed * Time.deltaTime);
            if (Input.GetKey("left"))
                transform.Rotate(-Vector3.up, speed * Time.deltaTime);
        }
    }
}
