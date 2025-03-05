using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;


    private static AudioManager instance;

    // AudioManger 타입의 정적 참조 변수
    public static AudioManager Instance { get { return instance; } }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        // 맨 처음 참조변수는 null을 가리킴 (데이터 안넣은 상태)
        // -> null이라면 참조변수가 자기 자신을 가리키게
        if(instance == null)
        {
            instance = this;
            Debug.Log(Instance);
        }
        else // null이 아니라면
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
