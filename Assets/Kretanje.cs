using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Kretanje : MonoBehaviour
{

    public float speed = 5f;

    public int coins;
    public TMP_Text coinText;


    // Start is called before the first frame update
    void Awake()
    {
        //Load the saved score (this value will be saved even if you restart the app)
        coins = PlayerPrefs.GetInt("Coins");
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
        }
        if(other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(2);
        }
        if(other.gameObject.tag == "Coin")
        {
            
            coins += 1;
            PlayerPrefs.SetInt("Coins", coins);
            coinText.text = "Coins :" + coins;
            Destroy(other.gameObject);
            
            Debug.Log(coins);
        }
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
       
    }

}






