using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputS : MonoBehaviour
{
    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("Particle System (1)").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && (Input.GetTouch(0).position.x >= 500 && Input.GetTouch(0).position.x <= 750 && Input.GetTouch(0).position.y <= 250))
        {
            ps.Emit(10);
        }
        else if (Input.touchCount == 2 && ((Input.GetTouch(0).position.x >= 500 && Input.GetTouch(0).position.x <= 750 && Input.GetTouch(0).position.y <= 250) || (Input.GetTouch(1).position.x >= 500 && Input.GetTouch(1).position.x <= 750 && Input.GetTouch(1).position.y <= 250)))
        {
            ps.Emit(10);
        }
    }
}
