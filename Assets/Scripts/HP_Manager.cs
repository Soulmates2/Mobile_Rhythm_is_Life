using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Manager : MonoBehaviour
{
    public static int HP;
    public static bool isGameEnd;
    Slider HpBar;

    void Awake()
    {
        HP = 100;
        isGameEnd = false;
        
    }

    private void Update()
    {
        if (HP <= 0)
        {
            Debug.Log("Hp <= 0");
            isGameEnd = true;
        }
    }
    public int getHP()
    {
        return HP;
    }
}