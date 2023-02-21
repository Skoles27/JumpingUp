//using System.Collections;
//using System.Collections.Generic;
//using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class FallCube : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 1f);
    }

    void Update()
    {
        transform.position += new Vector3 (0, 0.1f, 0);
    }
}
