using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject camera;
    private float horizVel = 0;
    private float vertVel = 0;
    private float zVel = 0;

    // Start is called before the first frame update
    void Start()
    {
        zVel = 5f;
        StartCoroutine(StopMove());
        //StartCoroutine(StartCamera());
        while (Time.deltaTime < 5)
        {
            transform.Rotate(Vector3.up * (90 * Time.deltaTime));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, vertVel, zVel);
        

    }

    

    IEnumerator StopMove()
    { 
        yield return new WaitForSeconds(7);
        zVel = 0;
    }

    IEnumerator StartCamera()
    {
        transform.Rotate(Vector3.up * 90 );
        yield return new WaitForSeconds(5);
        transform.Rotate(Vector3.up * 0);
    }
}

