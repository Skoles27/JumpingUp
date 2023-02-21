//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCashCube : MonoBehaviour
{

    public Text CashCubes;
    public AudioClip collectCashCube;

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "CashCubes")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("CashCubes", PlayerPrefs.GetInt("CashCubes") + 1);
            CashCubes.text = PlayerPrefs.GetInt("CashCubes").ToString();
            GetComponent<AudioSource>().clip = collectCashCube;
            GetComponent<AudioSource>().Play();
            
        }
    }
}
