using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Button clickbutton1 = null;
    public Button clickbutton2 = null;

    void OnButtonClick(Button clickbutton)
    {
        if(clickbutton1 == null) 
        {
            clickbutton1 = clickbutton;
        }

        else if(clickbutton2 == null)
        {
            clickbutton2 = clickbutton;

            if(clickbutton1.GetComponent<Image>().sprite == clickbutton2.GetComponent<Image>().sprite)
            {
                clickbutton1.gameObject.SetActive(false);
                clickbutton2.gameObject.SetActive(false);
            }

            clickbutton1 = null;
            clickbutton2 = null;
        }
    }



    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
