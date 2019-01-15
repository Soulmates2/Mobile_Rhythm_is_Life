using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Reflection;

public class change_scene : MonoBehaviour
{
    public static AudioClip clip;
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("0_start");
    }

    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("1_select_song");
    }

    public void anacne()
    {
        BmsLoader.bmsFileName = "MINO - anacne.bms";
        SceneManager.LoadScene("anacne");
    }

    public void bbibbi()
    {
        BmsLoader.bmsFileName = "IU - bbibbi.bms";
        SceneManager.LoadScene("bbibbi");
    }

    public void twinkle()
    {
        BmsLoader.bmsFileName = "Mozzart - Twinkle.bms";
        SceneManager.LoadScene("twinkle");
    }

    public void ChangeThirdScene()
    {
        
        Debug.Log("tttttttt");
        SceneManager.LoadScene("2_ingame");
    }

    public void ChangeFourthScene()
    {
        SceneManager.LoadScene("3_game_result");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; //play모드를 false로
        #elif UNITY_WEBPLAYER
            Application.OpenURL("http://google.com"); // 구글 웹 전환
        #else
            Application.Quit(); // 어플리케이션 종료
        #endif
    }
}
