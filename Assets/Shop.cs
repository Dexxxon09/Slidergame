using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
