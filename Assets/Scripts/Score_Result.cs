using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Result : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Text score = GameObject.Find("score").GetComponent<Text>();
        score.text = Score_Manager.score.ToString();

        Text combo = GameObject.Find("combo").GetComponent<Text>();
        combo.text = "Max Combo:" + Combo_Manager.maxcombo.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
