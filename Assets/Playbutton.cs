using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Playbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void Shop()
    {
        SceneManager.LoadScene(3);
    }
}
