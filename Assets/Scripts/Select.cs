//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    //[HideInInspector]
    public GameObject SelectCube, BuyCube, mainCube;
    public string nowCube;
    // public GameObject[] cubes;

    void Start()
    {
        if (PlayerPrefs.GetString("Cube 1")!="Open")
        {
            PlayerPrefs.SetString("Cube 1", "Open");
        }

      /*  for (int i = 0; i < cubes.Length; i++)
        {
            if (PlayerPrefs.GetString("Now Cube") == cubes[i].name)
            {
                mainCube.GetComponent<MeshRenderer>().material = cubes[i].GetComponent<MeshRenderer>().material;
                break;
            }
         }*/
    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
        nowCube = other.gameObject.name;
        other.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
        if (PlayerPrefs.GetString(other.gameObject.name)== "Open")
        {
            SelectCube.SetActive(true);
            BuyCube.SetActive(false);
        }
        else
        {
            SelectCube.SetActive(false);
            BuyCube.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        other.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
    }
}
