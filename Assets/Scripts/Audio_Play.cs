using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio_Play : MonoBehaviour
{
    private AudioSource songaudio;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("p", 1);
    }

    private void p()
    {
        songaudio = GetComponent<AudioSource>();
        songaudio.Play();
    }

    private void delay()
    {
        Debug.Log("end");
        //점수창으로 가기
        if (BmsLoader.bmsFileName == "MINO - anacne.bms")
        {
            SceneManager.LoadScene("anacne_result");
        }
        else if (BmsLoader.bmsFileName == "IU - bbibbi.bms")
        {
            SceneManager.LoadScene("bbibbi_result");
        }
        else
        {
            SceneManager.LoadScene("twinkle_result");
        }
        //SceneManager.LoadScene("3_game_result");
        Destroy(this);

    }
    // Update is called once per frame
    void Update()
    {
        if (HP_Manager.isGameEnd)
        {
            Invoke("delay", 0.2f);
        }
        else if (songaudio != null && !songaudio.isPlaying)
        {
            Invoke("delay", 2);
        }
    }
}
