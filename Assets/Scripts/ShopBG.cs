//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ShopBG : MonoBehaviour
{

    public GameObject detectClicks, allCubes;

    void OnEnable()
    {
        detectClicks.GetComponent<BoxCollider>().enabled = false;
        allCubes.SetActive(true);
    }

    void OnDisable()
    {
        detectClicks.GetComponent<BoxCollider>().enabled = true;
        allCubes.SetActive(false);
    }
}

