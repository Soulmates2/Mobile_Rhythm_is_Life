using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo_Update : MonoBehaviour
{
    Text comboLabel;
    // Start is called before the first frame update
    void Start()
    {
        comboLabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        comboLabel.text = "Combo  "+Combo_Manager.combo.ToString();
    }
}
