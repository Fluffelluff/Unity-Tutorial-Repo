using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsPractice:MonoBehaviour
{



    [SerializeField]
    string healthKey = "DEMOCRACY";

    [SerializeField]
    int vitality = 100;

    [SerializeField]
    bool integrity = false;

    [SerializeField]
    bool orbitalStrike = false;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(healthKey);
        if (PlayerPrefs.HasKey(healthKey))
        {
            Debug.Log("PROSPERITY");
            Debug.Log(PlayerPrefs.GetInt(healthKey));
        }
        else
        {
            Debug.Log("SUPER EARTH IS SAD");
        }

        if (integrity == true)
        {
            PlayerPrefs.SetInt(healthKey, vitality);
            PlayerPrefs.Save();
            
        }
        
        
        if (vitality > 9000)
        {
            Debug.Log("HOLY FUCK SOLDIER IT'S OVER 9000!");
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("FREEDOM");
            orbitalStrike = true;
                                    

        }

        if (orbitalStrike == true)
        {
            PlayerPrefs.DeleteAll();
        }

    }
}
