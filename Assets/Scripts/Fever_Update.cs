using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fever_Update : MonoBehaviour
{
    Text Fever;
    // Start is called before the first frame update
    void Start()
    {
        Fever = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Combo_Manager.fever == 1)
            Fever.text = "X " + Combo_Manager.fever.ToString(); // 하양

        if (Combo_Manager.fever == 2)
            Fever.text = "<color=#f6d04d>" + "X " + Combo_Manager.fever.ToString() + "</color>"; // 노랑

        if (Combo_Manager.fever == 3)
            Fever.text = "<color=#8bc24c>" + "X " + Combo_Manager.fever.ToString() + "</color>"; // 초록

        if (Combo_Manager.fever == 4)
            Fever.text = "<color=#50C1E9>" + "X " + Combo_Manager.fever.ToString() + "</color>"; // 파랑

        if (Combo_Manager.fever == 5)
            Fever.text = "<color=#F71E35>" + "X " + Combo_Manager.fever.ToString() + "</color>"; // 빨강
        
    }
}
