using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UiManager : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text positiontext;
    public TMP_Text positiontext2;
    public float geschwindigkeit;
    public float position1;
    public float position2;
    // Start is called before the first frame update
    void Start()
    {
        geschwindigkeit = 0f;
        position1 = 0;
        position2 = 0;
        text.text = geschwindigkeit.ToString() + "m/s";
        positiontext.text = position1.ToString();
        positiontext2.text = position2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = geschwindigkeit.ToString() + "m/s";
        positiontext.text = position1.ToString() + "X";
        positiontext2.text = position2.ToString() + "Y";
    }
}
