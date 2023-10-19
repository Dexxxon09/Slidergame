using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0.5f;
            Time.fixedDeltaTime = Time.fixedDeltaTime * 0.5f;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.fixedDeltaTime;
        }
    }
}
