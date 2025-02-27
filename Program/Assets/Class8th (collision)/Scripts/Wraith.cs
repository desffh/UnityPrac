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

    // 키 입력은 Update에서 받기
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
        // 게임 오브젝트가 물리적인 충돌을 했을 때
        // 호출되는 이벤트 함수입니다.

        Debug.Log("OnCollisionEnter");

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay
        // 게임 오브젝트가 물리적인 충돌 중일 때
        // 호출되는 이벤트 함수입니다.

        Debug.Log("OnCollisionStay");

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnCollisionExit
        // 게임 오브젝트가 물리적인 충돌을 벗어났을 때
        // 호출되는 이벤트 함수입니다.
        Debug.Log("OnCollisionExit");

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        // OnTriggerEnter
        // 게임 오브젝트가 물리적이지 않은 충돌을 했을 때
        // 호출되는 이벤트 함수입니다.
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        // OnTriggerStay
        // 게임 오브젝트가 물리적이지 않은 충돌 중일 때,
        // 호출되는 이벤트 함수입니다.
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        // OnTriggerExit
        // 게임 오브젝트가 물리적이지 않은 충돌을 벗어났을 때
        // 호출되는 이벤트 함수입니다.
        Debug.Log("OnTriggerExit");
    }

}
