using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloningScript : MonoBehaviour
{

    [SerializeField]
    GameObject toClone = null;
    [SerializeField]
    int numClones = 0;
    [SerializeField]
    float minPos = 0.0f;
    [SerializeField]
    float maxPos = 0.0f;
   
   


    // Start is called before the first frame update
    void Start()
    {
        for (int cloneCount = 0; cloneCount < numClones; ++cloneCount)
        {
            GameObject clonedObject = null;
            clonedObject = Instantiate(toClone);
            Vector3 randomPos = Vector3.zero;
            randomPos.x = Random.Range(minPos, maxPos);
            randomPos.y = Random.Range(minPos, maxPos);
            float randomNumber = Random.Range(-10.0f, 10.0f);
            clonedObject.transform.position = randomPos;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
