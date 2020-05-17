using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(videoLength());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator videoLength()
    {
        yield return new WaitForSeconds(120);
        SceneManager.LoadScene("End Screen");
    }
}
