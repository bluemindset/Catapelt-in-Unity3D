using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reload : MonoBehaviour
{
    public Rigidbody weight;
    public Rigidbody helper;
    private GameObject beam;
    private Quaternion defaultRotation;
    private float default_mass;
    float startrot;
    Vector3 startpospayload;
    public GameObject payload;
    private GameObject payloadput;
    private GameObject payloadsling;
    private bool complete = true;
    private void Start()
    {
        beam = GameObject.FindGameObjectWithTag("Respawn");
        payload = GameObject.FindGameObjectWithTag("Payload");
        payloadput = GameObject.FindGameObjectWithTag("PayloadPut");
        default_mass = helper.mass;
        startrot = transform.rotation.eulerAngles.z;
        startpospayload = payloadput.transform.position;
        startpospayload += new Vector3(0, 1, 0);
        payloadsling = GameObject.FindGameObjectWithTag("payload_sling");
    }

    void Update()
    {
        startpospayload = payloadput.transform.position;
        startpospayload += new Vector3(0, 1, 0);
        default_mass = helper.mass;
        if (Input.GetKey("r") && !this.GetComponent<Rigidbody>().isKinematic)
        {
            weight.mass = 1;
            StartCoroutine(RotateZaxis(Vector3.forward, startrot - beam.transform.rotation.eulerAngles.z, 1.0f));
            StartCoroutine(WaitPos());   
        }
    }

    IEnumerator RotateZaxis(Vector3 axis, float angle, float duration = 1.0f)
    {
        Quaternion from = transform.rotation;
        Quaternion to = transform.rotation;
        to *= Quaternion.Euler(axis * angle);
        float lap = 0.0f;
        while (lap < duration)
        {
            transform.rotation = Quaternion.Slerp(from, to, lap / duration);
            lap += Time.deltaTime;
            yield return null;
        }
        transform.rotation = to;
        weight.mass = default_mass;
        this.GetComponent<Rigidbody>().isKinematic = true;
        complete = true;
    }

    IEnumerator WaitPos()
    {
        yield return new WaitForSeconds(1.5f);
        if (complete)
        {
            var payload1 =  Instantiate(payload, startpospayload, Quaternion.identity);
            payload1.transform.SetParent(payloadsling.transform);
            complete = false;
        }
    }
}






