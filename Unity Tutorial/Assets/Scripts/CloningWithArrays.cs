using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloningWithArrays : MonoBehaviour
{
    [SerializeField]
    GameObject[] toClone = null;
    GameObject chosenToClone = null;
    GameObject clonedObject = null;

    [SerializeField]
    float minPos = -10;
    [SerializeField]
    float maxPos = 10;
    Vector3 randomPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        int chosenIndex = Random.Range(0, toClone.Length);
        chosenToClone = toClone[chosenIndex];
        clonedObject = Instantiate(chosenToClone);
        randomPos.x = Random.Range(minPos, maxPos);
        randomPos.y = Random.Range(minPos, maxPos);
        clonedObject.transform.position = randomPos;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
