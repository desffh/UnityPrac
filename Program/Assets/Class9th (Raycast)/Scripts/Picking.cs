using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    [SerializeField] Ray ray; // ������ ���� ���� 


    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // ī�޶� ������Ʈ�� ���̷�Ʈ�� ���� �� �ִ� �ڵ� (Camera.main == ���� ī�޶� �ǹ�)
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.Log("ray.direction : " + ray.direction);
            Debug.Log("ray.origin : " + ray.origin); //  
        }
    }
}
