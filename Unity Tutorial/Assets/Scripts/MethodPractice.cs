using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodPractice : MonoBehaviour
{
    [SerializeField]
    string Hi = "Hello again";
    [SerializeField]
    string Mushrooms = "Mushroom";
    [SerializeField]
    string Snake = null;

    //------------------------------------------------
    void ComputerSays()
    {
        Hi = Hi + Hi;
        Debug.Log(Hi);
        string Snake = "SNAAAAAKE";
        Debug.Log(Snake);
    }


    //------------------------------------------------
    void MushroomMan()
    {
        Debug.Log(Mushrooms);
        string Snake = "IT'S A SNAAAAKE";
        Debug.Log(Snake);
    }


    //------------------------------------------------
    // Start is called before the first frame update
    void Start()
    {
        Hi = "Hello again";
        Mushrooms = "Mushroom";
        Hi = Hi + Hi;
        ComputerSays();
        Hi = Hi + Hi;

        ComputerSays();
        Mushrooms = Mushrooms + " " + Mushrooms;
        MushroomMan();
        Debug.Log(Snake);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
