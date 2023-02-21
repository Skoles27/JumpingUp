//using System;
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textFade : MonoBehaviour
{
    private Text txt;
    private Outline oLine;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent <Text> ();
        oLine = GetComponent <Outline> ();
    }

    // Update is called once per frame
    void Update()
    {
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
        oLine.effectColor = new Color(oLine.effectColor.r, oLine.effectColor.g, oLine.effectColor.b, txt.color.a);
    }
}
