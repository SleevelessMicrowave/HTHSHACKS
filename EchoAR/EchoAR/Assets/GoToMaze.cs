using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToMaze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitFiveSeconds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitFiveSeconds()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("shiva");
    }
}
