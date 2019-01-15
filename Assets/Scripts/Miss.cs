using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Miss : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("miss");
        Combo_Manager.combo = 0;
        HP_Manager.HP -= 5;
        Destroy(other.gameObject);
        Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
        Judgement.text = "<color=#D0DFE6>" + "Miss" + "</color>";
        Invoke("Judgement", 1);

    }

    public void Judgement()
    {
        Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
        Judgement.text = "";

    }
}
