using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    [SerializeField] Ray ray; // ������ ���� ���� 
    [SerializeField] RaycastHit raycastHit;

    [SerializeField] private float attack;

    [SerializeField] LayerMask layerMask;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // ī�޶� ������Ʈ�� ���̷�Ʈ�� ���� �� �ִ� �ڵ� (Camera.main == ���� ī�޶� �ǹ�)
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // �߻��� ����, ��¿� �Ű������� ���� ����
            if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity, layerMask))
            {
                Debug.Log(raycastHit.collider.transform.root.name);

                // ��ũ��Ʈ�� �����ϴ� �θ��ʿ��� �� ������Ʈ (�ݶ��̴��� �ڽĿ� ������)
                raycastHit.collider.transform.root.GetComponent<Health>().Damage(attack);
            }
        }
    }
}
