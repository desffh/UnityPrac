using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text[] texts = new Text[3];

    public string[] strings;

    void Start()
    {

        for (int i = 0; i < texts.Length; i++) 
        {
            strings[i] = texts[i].text;
        }
    }

    void Update()
    {
        
    }
    
}
