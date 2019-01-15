using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    public static int score;
    private void Awake()
    {
        score = 0;
    }
}
