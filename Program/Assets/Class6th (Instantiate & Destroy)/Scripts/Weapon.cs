using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    // 외부에서 미리 값을 지정 (자식의 값들)
    [SerializeField] protected Vector3 direction;
    [SerializeField] protected Vector3 rotation;
    
    // 추상함수로 정의만 해두기
    public abstract void Attack();


    // public이나 protected로 하면 자식이 재정의 된 게 아니면 부모꺼로 알아서 호출된다
    public void Start()
    {
        transform.position = direction;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
