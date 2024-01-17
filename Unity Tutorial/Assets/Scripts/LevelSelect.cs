using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{

    [SerializeField]
    TMP_Text[] levelText = null;
    [SerializeField]
    int numUnlocked = 0;


    // Start is called before the first frame update
    void Start()
    {
        for (int levelIndex = 0; levelIndex < levelText.Length; ++levelIndex) 
        {
            TMP_Text levelToCheck = levelText[levelIndex];
            if (levelIndex >= numUnlocked)
            {
                levelToCheck.text = ("LOCKED");
                levelToCheck.color = Color.red;
            }

            
         
             
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
