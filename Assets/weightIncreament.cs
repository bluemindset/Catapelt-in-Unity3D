using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightIncreament : MonoBehaviour {

	private Rigidbody r ;
    private GameObject w;
    private Rigidbody h;
    private void Start()
    {
        r=this.GetComponent<Rigidbody>();
        w= GameObject.FindGameObjectWithTag("weight");
        h = GameObject.FindGameObjectWithTag("helper").GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKey("up"))
        {
            w.transform.localScale += new Vector3(0.02f, 0,0); //Increase the scale of the weight
            r.mass += 2;
            h.mass += 2;
        }
        if (Input.GetKey("down"))
        {
            w.transform.localScale -= new Vector3(0.02f, 0,0); //Increase the scale of the weight
            r.mass -= 2;
            h.mass -= 2;

        }
    }
}
