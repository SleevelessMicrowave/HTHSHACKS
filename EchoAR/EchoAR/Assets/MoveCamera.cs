using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position += new Vector3(0, 0, 0.2f);
        StartCoroutine(WaitThreeSeconds());
    }

    

    IEnumerator WaitThreeSeconds()
    {
        yield return new WaitForSeconds(3);
        camera.transform.position += new Vector3(0, 0, 0);
    }
}

