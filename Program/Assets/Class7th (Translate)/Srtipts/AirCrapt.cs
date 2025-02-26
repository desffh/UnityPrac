using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCrapt : MonoBehaviour
{
    [SerializeField] Vector3 direction;

    [SerializeField] float speed;

    void Start()
    {

    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // Time.deltaTime
        // ������ �������� �Ϸ�� �� ����� �ð��Դϴ�.
        
        // ������ ����ȭ
        direction.Normalize();

        transform.position = transform.position + direction * Time.deltaTime * speed;
    }
}
