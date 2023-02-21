//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class DeleteBlocks : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            Destroy(other.gameObject);
        }
    }
}
