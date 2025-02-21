using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text [] texts;
    public string [] strings;

    [SerializeField] Button button; // 버튼 컴포넌트


    private void Awake()
    {
        button = GetComponent<Button>();

    }

    // 런타임중에 text 데이터가 들어가게끔 만든 것
    void Start()
    {
        for (int i = 0; i < texts.Length; i++) 
        {
            texts[i].text = strings[i];
        }
    }

    public void ColorChange()
    {
        // button.colors
    }

    public void Execute()
    {
        Debug.Log("Execute");
    }

    public void Shop()
    {
        Debug.Log("Shop");
    }

    public void Quit()
    {
        Debug.Log("Quit");
    }

    public void addlistener()
    {
        Debug.Log("AddListener");
    }

}
