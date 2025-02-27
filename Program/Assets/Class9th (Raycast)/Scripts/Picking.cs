using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    [SerializeField] Ray ray; // 광선에 대한 정보 


    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // 카메라 오브젝트를 다이렉트로 넣을 수 있는 코드 (Camera.main == 메인 카메라를 의미)
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.Log("ray.direction : " + ray.direction);
            Debug.Log("ray.origin : " + ray.origin); //  
        }
    }
}
