using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reload : MonoBehaviour {

    public Rigidbody weight;
    public Transform beam;
    public Transform payload;



    // Update is called once per frame
    void Update () {
		
        if (Input.GetKeyDown("t"))
        {
            weight.mass = 1;
            //beam.eulerAngles= new Vector3(0, 90, 15);
            weight.mass = 1000;
        }

    }
}
