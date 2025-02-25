using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    // �ܺο��� �̸� ���� ���� (�ڽ��� ����)
    [SerializeField] protected Vector3 direction;
    [SerializeField] protected Vector3 rotation;
    
    // �߻��Լ��� ���Ǹ� �صα�
    public abstract void Attack();


    // public�̳� protected�� �ϸ� �ڽ��� ������ �� �� �ƴϸ� �θ𲨷� �˾Ƽ� ȣ��ȴ�
    public void Start()
    {
        transform.position = direction;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
