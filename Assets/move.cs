using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float force = 1000f;
    public Rigidbody r;
    private void OnMouseDown()
    {
        this.GetComponent<Rigidbody>().AddForce(0,0,-force, ForceMode.Acceleration);
        
    }
}
