//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Harder : MonoBehaviour
{
    public GameObject detectClicks;
    private bool hard;

    void Update()
    {
        if (CubeJump.count_blocks > 0)
        {
            if (CubeJump.count_blocks % 7 == 0 && !hard)
            {
                hard = true;
                print("Harder");
                Camera.main.GetComponent<Animation>().Play("Harder");
                detectClicks.transform.position = new Vector3(10.77f, 7.14f, -5.25f);
                detectClicks.transform.eulerAngles = new Vector3(31.6f, -62.4f, 0f);
            }
            else if ((CubeJump.count_blocks % 7) - 1 == 0 && hard)
            {
                hard = false;
                print("Easier");
                Camera.main.GetComponent<Animation>().Play("Easier");
                detectClicks.transform.position = new Vector3(0f, 0f, -7.97f);
                detectClicks.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
        }
    }
}
