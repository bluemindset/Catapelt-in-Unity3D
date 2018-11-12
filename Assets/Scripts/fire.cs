using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody chain;
    void Update()
    {
        if (Input.GetKey("space") && !(Input.GetKey("left") || Input.GetKey("right")))
        {
            StartCoroutine(WaitPos());
        }
    }
    IEnumerator WaitPos()
    {
        yield return new WaitForSeconds(0.5f);
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        chain.isKinematic = false;
        ball.transform.SetParent(null);
    }
}