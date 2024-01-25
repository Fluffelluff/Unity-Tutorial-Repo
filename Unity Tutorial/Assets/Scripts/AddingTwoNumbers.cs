using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddingTwoNumbers : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreDisplay = null;

    private int currentScore = 0;

    [SerializeField]
    int debugAdd = 0;
    //----------------------------------------------------------------
    public int AddScore(int toAdd)
    {
        toAdd += currentScore;
        return currentScore;
    }
    //----------------------------------------------------------------


    void Start()
    {
        int newScore = AddScore(debugAdd);
        Debug.Log("New Score is: " + newScore);


    }

    // Update is called once per frame
    void Update()
    {
        




    }
}
