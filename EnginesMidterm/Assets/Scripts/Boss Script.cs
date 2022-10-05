using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool bossenter = false;
    public GameObject bossobject;
    Time time;

    void Start()
    {
        bossenter = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (bossenter == true)//could also be based on player position
        {
           //instanciate the BOSS LIGHT OBJECT//
        }


    }
}
