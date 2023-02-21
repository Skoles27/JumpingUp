//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class RMat : MonoBehaviour
{

    public GameObject[] cubes;

    void Start()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            if (PlayerPrefs.GetString("Now Cube") == cubes[i].name)
            {
                GetComponent<MeshRenderer>().material = cubes[i].GetComponent<MeshRenderer>().material;
                break;
            }
        }
    }
}
