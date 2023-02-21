using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
//using System.Media;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class GameArrangement : MonoBehaviour
{
    public GameObject[] cubes;
    public Animation cubes_anim, block;
    public GameObject buttons, m_cube, spawn_blocks, CashCube;
    public Light dirLight, dirLight_2;
    public Text playTxt, gameName, record;

    private bool clicked;

    void update ()
    {
        if (clicked && dirLight.intensity != 0)
            dirLight.intensity -= 0.03f;
        if (clicked && dirLight_2.intensity >= 1.05f)
            dirLight_2.intensity -= 0.025f;
    }

   void OnMouseDown ()
    {
        if (!clicked)
        {
            StartCoroutine(delCubes());

            clicked = true;

            playTxt.gameObject.SetActive(false);
            record.gameObject.SetActive(true);
            CashCube.SetActive(true);
            gameName.text = "0";
            buttons.GetComponent<ScrollObj>().speed = 700f;
            buttons.GetComponent<ScrollObj>().checkPos = 700f;
            m_cube.GetComponent<Animation>().Play("StartGameCube");
            StartCoroutine(CubeToBlock());
            m_cube.transform.localScale = new Vector3(1f, 1f, 1f);
            cubes_anim.Play();
        }
    }

    IEnumerator delCubes ()
    {
        for(int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.5f);
            cubes[i].GetComponent<FallCube>().enabled = true;
        }

        spawn_blocks.GetComponent<SpawnBlocks>().enabled = true;
    }

    IEnumerator CubeToBlock()
    {
        yield return new WaitForSeconds(m_cube.GetComponent<Animation>().clip.length + 0.5f);
        block.Play();

        m_cube.AddComponent<Rigidbody>();
    }
}
