using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optimizer : MonoBehaviour {

    public Rigidbody r1;
    public Rigidbody r2;
    public Rigidbody r3;
    public Rigidbody r4;

    void OnCollisionEnter(Collision collision)
    {
        r1.isKinematic = true;
        r2.isKinematic  = true;
        r3.isKinematic = true;
        r4.isKinematic = true;
    }
}
