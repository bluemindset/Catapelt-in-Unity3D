﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    private int speed = 20;
    void Update()
    {
        if (Input.GetKey("right"))
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        if (Input.GetKey("left"))         
                 transform.Rotate(-Vector3.up, speed*Time.deltaTime);
        
    }
}