using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] int random;
    [SerializeField] AudioClip audioClip;

    [SerializeField] WaitForSeconds waitForSeconds;



    private void Start()
    {
        StartCoroutine(Coroutine());

        waitForSeconds = new WaitForSeconds(5.0f);
    }
    IEnumerator Coroutine()
    {
        // while�� �������� �̸� �������� ���� �Ҵ� 

        while(true)
        {
            yield return waitForSeconds;

            AudioManager.Instance.Listener(audioClip);
            
        }
    }
}
