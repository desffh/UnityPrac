using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] GameObject[] weapons;
    [SerializeField] List<GameObject> weaponList;

    [SerializeField] bool check;

    GameObject clone;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Equip();

            Shift();
        }

        if(clone != null) 
        {
            if(Input.GetMouseButtonDown(0))
            {
                clone.GetComponent<Weapon>().Attack();
            }  
        }
    }

    public void Equip()
    {
        if (check == true)
        {
            return;
        }

        if (weapons.Length <= count)
        {
            check = true;
            return;
        }

        clone = Instantiate(weapons[count++]);

        if(weaponList.Count >= 1)
        {
            weaponList[weaponList.Count-1].gameObject.SetActive(false);
        }

        clone.gameObject.SetActive(true);

        weaponList.Add(clone);
    }

    public void Shift()
    {
        if (check)
        {
            for(int i = 0; i < weaponList.Count; i++) 
            {
                weaponList[i].gameObject.SetActive(false);
            }
            weaponList[count++ % weaponList.Count].gameObject.SetActive(true);

        }
    }


}