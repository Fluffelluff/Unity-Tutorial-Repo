using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

   
    //string combinedString;

    // editor variables
    [SerializeField]

    string editorString = "VALUE";

    [SerializeField]

    float targetScale = 1.0f;

    Vector3 changingScale = new Vector3(1.0f, 1.0f, 1.0f);

    [SerializeField]
    SpriteRenderer playerSprite = null;

    [SerializeField]
    Color spriteColor = Color.white;




    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("you were supposed to bring balance to the force");
        Debug.Log("Not plunge it into darkness!");

        transform.Translate(20, 0, 0);
        */

        //Declating a variable calle firstString
        // string firstString = "You shall not...";
        //string secondString = " PASS!";

        // string combinedString = firstString + secondString;

        // Debug.Log(combinedString);

        Debug.Log(editorString);
        playerSprite.color = spriteColor;

    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log("No no no no no no no no!");
        */
        targetScale = targetScale + 0.01f;
        Debug.Log(targetScale);
        //Debug.Log(combinedString);

        changingScale.x = targetScale;
        changingScale.y = targetScale;
        changingScale.z = targetScale;

        transform.localScale = changingScale;
        }
}
