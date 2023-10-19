using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    public void Bought()
    {
        GameObject.Find("BuySlowMo").GetComponentInChildren<Text>().text = "Bought";
        GameObject.Find("BuySlowMo").GetComponent<Image>().color = Color.gray;
        GameObject.Find("BuySlowMo").GetComponent<Button>().interactable = false;
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
