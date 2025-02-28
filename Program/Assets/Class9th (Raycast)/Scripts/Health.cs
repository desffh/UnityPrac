using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float health;

    private void Start()
    {
        health = 100f;
    }

    public void Damage(float damage)
    {
        health -= damage;
        Debug.Log("���� ü�� : " + health);
        if(health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("���� ������Ʈ �ı�");
        }
    }
}
