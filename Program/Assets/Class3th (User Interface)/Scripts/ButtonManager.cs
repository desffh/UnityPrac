using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text [] texts;
    public string [] strings;

    // ��Ÿ���߿� text �����Ͱ� ���Բ� ���� ��
    void Start()
    {
        for (int i = 0; i < texts.Length; i++) 
        {
            texts[i].text = strings[i];
        }
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
}
