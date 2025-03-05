using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;


    private static AudioManager instance;

    // AudioManger Ÿ���� ���� ���� ����
    public static AudioManager Instance { get { return instance; } }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        // �� ó�� ���������� null�� ����Ŵ (������ �ȳ��� ����)
        // -> null�̶�� ���������� �ڱ� �ڽ��� ����Ű��
        if(instance == null)
        {
            instance = this;
            Debug.Log(Instance);
        }
        else // null�� �ƴ϶��
        {

        }
    }

    public void Listener(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }


    void Update()
    {
        
    }
}
