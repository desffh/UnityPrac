using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Dialog : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProUGUI; // ���� NULL�� ���ִ� ����

    private void Awake()
    {
       // �ش� ��ũ��Ʈ�� ������ ���� ������Ʈ�� �ִ� ������Ʈ�� �������� 
       // ����Ƽ ������ ���ο��� ���� �Ҵ��ص� ������ �̰� �� ���ϴ� 
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    // �ܺο��� ȣ���ؼ� ����ϱ� ������ ���������� public
    // DialogManager���� ȣ���ؼ� ����
    // -> ȣ���ؼ� �Ű������� ���� string���� textMeshPro������Ʈ�� text������ ����
    public void Message(string content)
    {
        textMeshProUGUI.text = content;
    }
}
