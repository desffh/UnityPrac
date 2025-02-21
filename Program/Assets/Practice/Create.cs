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

        // 버튼들을 랜덤으로 섞기
        ShuffleButtonList(tempButtonList);

        // 5개의 버튼이 각각 2개씩 들어간 리스트 생성
        if (buttonObject.Length == 5)  // 배열 크기 확인
        {
            // 버튼을 생성하고, 각 버튼을 GridLayoutGroup에 배치
            foreach (var buttonPrefab in tempButtonList)
            {
                if (buttonObject != null)  // null 체크
                {
                    Button button = Instantiate(buttonPrefab);
                    button.transform.SetParent(gridLayoutGroup.transform, false);
                    buttonList.Add(button);
                }
            }
        }
    }
    // 버튼 리스트 섞기 (랜덤 배치)
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
