using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line4_good : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (Input.touchCount == 1 && (Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).position.x >= 1200 && Input.GetTouch(0).position.x <= 1400 && Input.GetTouch(0).position.y <= 250))
        {
            Score_Manager.score += 10 * Combo_Manager.fever;
            Combo_Manager.combo++;
            if (HP_Manager.HP < 100) HP_Manager.HP++;
            Destroy(other.gameObject);
            Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
            Judgement.text = "<color=#1F6ED4>" + "Perfect" + "</color>";
            Invoke("Judgement", 1);
        }
        else if (Input.touchCount == 2 && ((Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).position.x >= 1200 && Input.GetTouch(0).position.x <= 1400 && Input.GetTouch(0).position.y <= 250) || (Input.GetTouch(1).phase == TouchPhase.Began && Input.GetTouch(1).position.x >= 1200 && Input.GetTouch(1).position.x <= 1400 && Input.GetTouch(1).position.y <= 250)))
        {
            Score_Manager.score += 10 * Combo_Manager.fever;
            Combo_Manager.combo++;
            if (HP_Manager.HP < 100) HP_Manager.HP++;
            Destroy(other.gameObject);
            Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
            Judgement.text = "<color=#1F6ED4>" + "Perfect" + "</color>";
            Invoke("Judgement", 1);
        }
    }
   
    public void Judgement()
    {
        Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
        Judgement.text = "";
    }
}
