using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject knife;

    [SerializeField] GameObject [] weapons;

    // ���� ������Ʈ Ÿ�� ����Ʈ
    [SerializeField] List<GameObject> weaponList;
     
    private int count;
    
    void Start()
    {
        count = 0;
    }

    public void Equip()
    {
        if(weapons.Length <= count)
        {
            return;
        }

        GameObject clone = Instantiate(weapons[count++]);
        clone.gameObject.SetActive(false);

        // ����Ʈ�� ������ ���� ������Ʈ �߰�
        weaponList.Add(clone);


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Equip();
        }
    }
}
