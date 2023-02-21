//using System.Collections;
//using System.Collections.Generic;
//using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

    public Sprite audio_on, audio_off;
    public GameObject shopBG;

    void Start()
    {
        if (gameObject.name == "audio")
        {
            if (PlayerPrefs.GetString("audio") == "off")
                /*transform.GetChild(0).gameObject.*/
                GetComponent<Image>().sprite = audio_off;
            //Camera.main.GetComponent<AudioListener>().enabled = true;
              AudioListener.volume = 1f;
        }
    }

  void OnMouseDown()
    {
        transform.localScale = new Vector3(1.30f, 1.30f, 1.30f);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1.00f, 1.00f, 1.00f);
    }

    void OnMouseUpAsButton()
    {
        GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "Restart":
                SceneManager.LoadScene("main");
                break;


            case "audio":
                if (PlayerPrefs.GetString("audio") == "off")
                {
                    GetComponent<Image>().sprite = audio_on;
                    PlayerPrefs.SetString("audio", "on");
                    //Camera.main.GetComponent<AudioListener>().enabled = true;
                    AudioListener.volume = 1f;
                }
                else
                {
                    GetComponent<Image>().sprite = audio_off;
                    PlayerPrefs.SetString("audio", "off");
                    //Camera.main.GetComponent<AudioListener>().enabled = false;
                    AudioListener.volume = 0f;
                }
                break;


            case "shop":
                shopBG.SetActive(!shopBG.activeSelf);
                break;


            case "close":
                shopBG.SetActive(false);
                break;
        }
    }
}

