using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject knife;

    [SerializeField] GameObject [] weapons;

    // 게임 오브젝트 타입 리스트
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

        // 리스트에 생성된 게임 오브젝트 추가
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
