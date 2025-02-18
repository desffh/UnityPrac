using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Dialog : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProUGUI; // 현재 NULL이 들어가있는 상태

    private void Awake()
    {
       // 해당 스크립트가 부착된 게임 오브젝트에 있는 컴포넌트를 가져오기 
       // 유니티 에디터 내부에서 직접 할당해도 되지만 이게 더 편하다 
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    // 외부에서 호출해서 써야하기 때문에 접근지정자 public
    // DialogManager에서 호출해서 쓰기
    // -> 호출해서 매개변수로 들어온 string값이 textMeshPro컴포넌트의 text값으로 변경
    public void Message(string content)
    {
        textMeshProUGUI.text = content;
    }
}
