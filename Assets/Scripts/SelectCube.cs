//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class SelectCube : MonoBehaviour
{
    public GameObject Which;
    public GameObject mainCube;

    void OnMouseDown()
    {
        if (mainCube != null)
        mainCube.GetComponent<MeshRenderer>().material = GameObject.Find(Which.GetComponent<Select>().nowCube).GetComponent<MeshRenderer>().material;
        PlayerPrefs.SetString("Now Cube", Which.GetComponent<Select>().nowCube);
    }


}

