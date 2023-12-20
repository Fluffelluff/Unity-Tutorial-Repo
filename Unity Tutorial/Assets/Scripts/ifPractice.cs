using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript3 : MonoBehaviour
{
    [SerializeField]
    string start = "Cheese";
    [SerializeField]
    int MessageChoice;

    [SerializeField]
    Boolean decision = false;

    //int number = 42069;
    float number = 1.1f;

    float flnum = 420.69f;
    



    // Start is called before the first frame update
    void Start()
    {
        /*if (MessageChoice == 1)
        {
            Debug.Log("Cool Number bro");

            decision = true;
        }*/

        decision = MessageChoice == 1;

        if (decision)
        {
            Debug.Log("you wanted this");

        }

    }

    // Update is called once per frame
    void Update()
    {
        number = number + 1f;
        //Debug.Log(start + number);
        //Debug.Log(flnum);
        flnum = flnum * number;
        //Debug.Log(flnum);
    }
}
