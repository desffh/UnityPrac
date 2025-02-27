using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wraith : MonoBehaviour
{
    [SerializeField] Rigidbody Rigidbody;

    [SerializeField] Vector3 direction;

    [SerializeField] float speed;

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Ű �Է��� Update���� �ޱ�
    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Rigidbody.position = Rigidbody.position + direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // OnCollisionEnter
        // ���� ������Ʈ�� �������� �浹�� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnCollisionEnter");

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay
        // ���� ������Ʈ�� �������� �浹 ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnCollisionStay");

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnCollisionExit
        // ���� ������Ʈ�� �������� �浹�� ����� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnCollisionExit");

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        // OnTriggerEnter
        // ���� ������Ʈ�� ���������� ���� �浹�� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        // OnTriggerStay
        // ���� ������Ʈ�� ���������� ���� �浹 ���� ��,
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        // OnTriggerExit
        // ���� ������Ʈ�� ���������� ���� �浹�� ����� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnTriggerExit");
    }

}
