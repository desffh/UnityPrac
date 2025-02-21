using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Information : MonoBehaviour
{
    [SerializeField] string title;
    [SerializeField] string description;

    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] Text descriptionText;


    private void Awake()
    {
        titleText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        descriptionText = transform.GetChild(1).GetComponent<Text>();
    }

    void Start()
    {
        titleText.text = title;
        descriptionText.text = description;
    }

}
