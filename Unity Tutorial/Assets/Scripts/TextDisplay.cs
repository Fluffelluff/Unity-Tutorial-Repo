using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TextDisplay : MonoBehaviour

{
    [SerializeField]
    TMP_Text fireText = null;

    [SerializeField]
    Color color1 = Color.white;


    // Start is called before the first frame update
    void Start()
    {
        fireText.text = ("KITTENS ARE FUCKING CUUUUUUUUUUUUUUTE");
    }

    // Update is called once per frame
    void Update()
    {
        fireText.color = new Color(1, Random.value, 1);
    }
}
