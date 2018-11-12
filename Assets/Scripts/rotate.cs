using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private int speed = 50;
    public Rigidbody r_beam;
    public GameObject beam;
    void Update()
    {
        if (r_beam.isKinematic && beam.transform.rotation.eulerAngles.z >= 14)
        {

            if (Input.GetKey("right"))
                StartCoroutine(WaitPos());
            if (Input.GetKey("left"))
                StartCoroutine(WaitPosm());

        }
    }
    IEnumerator WaitPos()
    {
        yield return new WaitForSeconds(0.5f);
        transform.Rotate(Vector3.up, speed * Time.deltaTime);

    }
    IEnumerator WaitPosm()
    {
        yield return new WaitForSeconds(0.5f);
        transform.Rotate(-Vector3.up, speed * Time.deltaTime);

    }
}