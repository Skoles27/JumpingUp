//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class BlockSamCube : MonoBehaviour
{
    private bool first;
    public AudioClip Drop;

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Cube" && first)
        {
            other.gameObject.GetComponent<MeshRenderer>().material.color = GetComponent<MeshRenderer>().material.color;
            GetComponent<AudioSource>().clip = Drop;
            GetComponent<AudioSource>().Play();
            
        }
        if (!first)
            first = true;
    }
}
