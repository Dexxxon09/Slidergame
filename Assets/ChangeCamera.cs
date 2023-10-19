using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    Camera MainCamera;
    
    public Camera CameraTwo;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera = Camera.main;
        
        MainCamera.enabled = true;
        CameraTwo.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (MainCamera.enabled)
            {

                CameraTwo.enabled = true;


                MainCamera.enabled = false;
            }

            else if (!MainCamera.enabled)
            {

                CameraTwo.enabled = false;


                MainCamera.enabled = true;
            }
        }
    }
}
 