//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class BuyCube : MonoBehaviour
{
    public GameObject Which;
    public GameObject selectBtn, mainCube;

/*   void Start()
    {
        PlayerPrefs.SetString("CashCube", "500");
    }
*/
    void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("CashCube") >= 30)
        {
            PlayerPrefs.SetString(Which.GetComponent <Select> ().nowCube, "Open");
            PlayerPrefs.SetString("Now Cube", Which.GetComponent<Select>().nowCube);
            PlayerPrefs.SetInt("CashCube", PlayerPrefs.GetInt("CashCube") - 30);
            mainCube.GetComponent<MeshRenderer>().material = GameObject.Find(Which.GetComponent<Select>().nowCube).GetComponent<MeshRenderer>().material;
            selectBtn.SetActive(true);
            gameObject.SetActive(false);
            GetComponentInParent<AudioSource>().Play();
        }
    }
}
