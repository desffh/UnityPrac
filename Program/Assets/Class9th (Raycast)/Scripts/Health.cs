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
        Debug.Log("현재 체력 : " + health);
        if(health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("게임 오브젝트 파괴");
        }
    }
}
