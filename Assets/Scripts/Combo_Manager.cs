using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo_Manager : MonoBehaviour
{
    public static int combo;
    public static int tempcombo;
    public static int maxcombo;
    public static int fever;
    private void Awake()
    {
        combo = 0;
        maxcombo = 0;
        fever = 1;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempcombo = combo;
        if (combo != 0 && tempcombo>maxcombo)
        maxcombo = tempcombo;
        if (combo >= 100)
        {
            fever = 5;
        }
        else if (combo >= 50)
        {
            fever = 4;
        }
        else if (combo >= 20)
        {
            fever = 3;
        }        
        else if (combo >= 10)
        {
            fever = 2;
        }        
        else
        {
            fever = 1;
        }

    }
}
