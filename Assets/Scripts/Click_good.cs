using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Click_good : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
            Score_Manager.score += 5;
            Combo_Manager.combo++;
            if (HP_Manager.HP < 100) HP_Manager.HP++;
            Destroy(other.gameObject);
            Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
            Judgement.text = "Good";
            Invoke("Judgement", 1);
      
    }

    public void Judgement()
    {
        Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
        Judgement.text = "";
    }
}
