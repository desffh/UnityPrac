using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Create : MonoBehaviour
{
    public Button [] buttonObject;

    public int buttoncount = 10;

    public Canvas canvas;

    public GridLayoutGroup gridLayoutGroup;

    public List<Button> buttonList = new List<Button>();

    public Click GetClick;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();

        gridLayoutGroup = GetComponentInChildren<GridLayoutGroup>();

        List<Button> tempButtonList = new List<Button>();

        foreach (var buttonPrefab in buttonObject)
        {
            tempButtonList.Add(buttonPrefab);
            tempButtonList.Add(buttonPrefab);
        }

        // ��ư���� �������� ����
        ShuffleButtonList(tempButtonList);

        // 5���� ��ư�� ���� 2���� �� ����Ʈ ����
        if (buttonObject.Length == 5)  // �迭 ũ�� Ȯ��
        {
            // ��ư�� �����ϰ�, �� ��ư�� GridLayoutGroup�� ��ġ
            foreach (var buttonPrefab in tempButtonList)
            {
                if (buttonObject != null)  // null üũ
                {
                    Button button = Instantiate(buttonPrefab);
                    button.transform.SetParent(gridLayoutGroup.transform, false);
                    buttonList.Add(button);
                }
            }
        }
    }
    // ��ư ����Ʈ ���� (���� ��ġ)
    private void ShuffleButtonList(List<Button> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Button temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }


   

    void Start()
    {
      
    }

    

    void Update()
    {
        
    }



}
