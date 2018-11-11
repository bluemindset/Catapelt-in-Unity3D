using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
  
    private bool clicked = false;
    public float speed = 1.0f;
    private float posy;
    private Vector3 end;

    void Start()
    {
        posy = gameObject.transform.position.y;
    }

    void Update()
    {

        //check if the screen is touched / clicked   
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray;

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                clicked = true;
                end = hit.point;
                end.y = posy;
            }

        }
        if (clicked)
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, end, 1 / (speed * (Vector3.Distance(gameObject.transform.position, end))));
        

 

    }
}