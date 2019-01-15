using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp_Update : MonoBehaviour
{
    Slider HpBar;
    // Start is called before the first frame update
    void Start()
    {
        HpBar = GameObject.Find("HpBar").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        HpBar.value = HP_Manager.HP;
    }
}