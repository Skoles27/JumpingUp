//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.Specialized;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnBlocks : MonoBehaviour
{

    public GameObject block, allCubes, CashCube;
    private GameObject blockInst;
    private Vector3 blockPos;
    private float speed = 7f;
    private bool OnPlace;

    void Start()
    {
        blockPos = new Vector3(Random.Range(0.4f, 2f), Random.Range(-3.5f, 0.4f), 0f);
        blockInst = Instantiate(block, new Vector3(6f, -6f, 0f), Quaternion.identity) as GameObject;
        blockInst.transform.localScale = new Vector3(RandScale(), blockInst.transform.localScale.y, blockInst.transform.localScale.z);
        blockInst.transform.parent = allCubes.transform;

        if (CubeJump.count_blocks % 4 == 0 && CubeJump.count_blocks != 0)
        {
            GameObject CashCubeInst = Instantiate(CashCube, new Vector3(blockInst.transform.position.x, blockInst.transform.position.y + 0.5f, blockInst.transform.position.z), Quaternion.Euler(Camera.main.transform.eulerAngles)) as GameObject;
            CashCubeInst.transform.parent = blockInst.transform;
        }
    }

    void Update () 
    {
        if (blockInst.transform.position != blockPos && !OnPlace)
            blockInst.transform.position = Vector3.MoveTowards(blockInst.transform.position, blockPos, Time.deltaTime * speed);
        else if (blockInst.transform.position == blockPos)
           OnPlace = true;

        if(CubeJump.jump && CubeJump.nextBlock)
        {
            blockPos = new Vector3(Random.Range(0.4f, 2f), Random.Range(-3.5f, 0.4f), 0f);
            blockInst = Instantiate(block, new Vector3(6f, -6f, 0f), Quaternion.identity) as GameObject;
            blockInst.transform.localScale = new Vector3(RandScale(), blockInst.transform.localScale.y, blockInst.transform.localScale.z);
            blockInst.transform.parent = allCubes.transform;

            if (CubeJump.count_blocks % 4 == 0 && CubeJump.count_blocks != 0)
            {
                GameObject CashCubeInst = Instantiate(CashCube, new Vector3(blockInst.transform.position.x, blockInst.transform.position.y + 0.5f, blockInst.transform.position.z), Quaternion.Euler(Camera.main.transform.eulerAngles)) as GameObject;
                CashCubeInst.transform.parent = blockInst.transform;
            }

            OnPlace = false;
        }
    }

    float RandScale()
    {
        float rand;
        if (Random.Range(0, 100) > 80)
            rand = Random.Range(1.2f, 2f);
        else
            rand = Random.Range(1.2f, 1.5f);
        return rand;
    }

}
