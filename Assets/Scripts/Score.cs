//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text record;
    private Text txt;
    private bool gameStart;

    void Start()
    {
        record.text = "Record: " + PlayerPrefs.GetInt("Record").ToString();
        txt = GetComponent <Text>();
        CubeJump.count_blocks = 0;
    }

    void Update()
    {
        if (txt.text == "0")
            gameStart = true;
        if (gameStart)
        {
            txt.text = CubeJump.count_blocks.ToString();
            if (PlayerPrefs.GetInt("Record") < CubeJump.count_blocks) ;
            {
                PlayerPrefs.SetInt("Record", CubeJump.count_blocks);
                record.text = "Record: " + PlayerPrefs.GetInt("Record").ToString();
            }
        }
    }
}
