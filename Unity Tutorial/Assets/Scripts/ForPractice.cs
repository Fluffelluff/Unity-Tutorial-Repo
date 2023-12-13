using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractice : MonoBehaviour
{
    

    [SerializeField]
    int Target = 50;

    [SerializeField]
    int Target2 = 20;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I COUNT SO POOR");
        Debug.Log("HERE WE GO");
        Debug.Log("HERE WE GO");
        Debug.Log("HERE WE GO NOW");

        for (int Rounds = 1; Rounds <= Target; Rounds += 1)
        {

            Debug.Log(Rounds + ", what comes after " + Rounds + "?"); 
        }

        Debug.Log("FOOOOOOOUUUUUURRRRRR");
        Debug.Log("I CAN ONLY COUNT TO FOUR");
        Debug.Log("I CAN ONLY COUNT TO FOUR");
        Debug.Log("I CAN ONLY COUNT TO");
        Debug.Log("FOOOOOOUUUUURRRRR");

        /* for (int Rounds = Target - 2; Rounds >= Target2; Rounds -= 2)
         {

             Debug.Log(Rounds + ", what doesn't come before " + Rounds + "?");
         }
        */

    }

    // Update is called once per frame
    void Update()
    {

       
    }
}
