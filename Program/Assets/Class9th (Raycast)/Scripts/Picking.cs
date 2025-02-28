using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    [SerializeField] Ray ray; // 광선에 대한 정보 
    [SerializeField] RaycastHit raycastHit;

    [SerializeField] private float attack;

    [SerializeField] LayerMask layerMask;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // 카메라 오브젝트를 다이렉트로 넣을 수 있는 코드 (Camera.main == 메인 카메라를 의미)
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // 발사할 레이, 출력용 매개변수로 값이 들어옴
            if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity, layerMask))
            {
                Debug.Log(raycastHit.collider.transform.root.name);

                // 스크립트가 존재하는 부모쪽에서 겟 컴포넌트 (콜라이더는 자식에 있지만)
                raycastHit.collider.transform.root.GetComponent<Health>().Damage(attack);
            }
        }
    }
}
