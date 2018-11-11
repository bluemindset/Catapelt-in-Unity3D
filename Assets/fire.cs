using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {

    public GameObject ball;
    public Rigidbody chain;
    // Update is called once per frame
    void Update () {

            if (Input.GetKeyDown("space"))
            {
                print("Fire!!");
           
            ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            chain.isKinematic = false;
            ball.transform.SetParent(null);
        }
    }
   
}
