//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MoveCubes : MonoBehaviour
{

    private bool moved = true;
    private Vector3 target;

    void Start()
    {
        target = new Vector3(-4.1f, 5.27f, -0.25f);
    }

 
    void Update()
    {
        if (CubeJump.nextBlock)
        {
            if (transform.position != target)
                transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 5f);
            else if (transform.position == target && !moved)
            {
                target = new Vector3(transform.position.x - 3.7f, transform.position.y + 3.6f, transform.position.z);
                CubeJump.jump = false;
                moved = true;
            }

            if (CubeJump.jump)
            {
                moved = false;
            }
        }
    }
}
