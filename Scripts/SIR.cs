using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class SIR : MonoBehaviour
{
    private Text text;
    private PandemicArea pandemicArea;

    // Start is called before the first frame update
    void Start()
    {
        pandemicArea = GetComponentInParent<PandemicArea>();
        text = GetComponent<Text>();      
    }

    // Update is called once per frame
    void LateUpdate()
    {
        text.text = "S = " + pandemicArea.healthyCounter +
                    "  I = " + pandemicArea.infectedCounter  +
                    "  R = " + pandemicArea.recoveredCounter + "\n" + 
                    "Time = " + Mathf.FloorToInt(Time.time);
        
    }
}
