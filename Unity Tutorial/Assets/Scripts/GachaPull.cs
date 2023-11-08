using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaPull : MonoBehaviour
{
    // Constants
    [SerializeField]
        private float startingCurrency = 100.0f;
    [SerializeField]
        private float pullCost = 50.0f;
    [SerializeField]
    private float rewardChance = 0.25f;       

    // Variables
    private int numPulls = 0;
    private float chanceRewardInverse = 0.0f;
    private float overallRewardInverse = 0.0f;
    private float overallRewardChance = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

        // Initialize numPulls to 0
        numPulls = 0;

        // Calculate numPulls based on startingCurrency and pullCost
        numPulls = (int)(startingCurrency / pullCost);

        // Display numPulls to the console
        Debug.Log("numPulls: " + numPulls);

        // Calculate chanceRewardInverse
        chanceRewardInverse = 1.0f - rewardChance;

        // Calculate overallRewardInverse using the power operator (^)
        overallRewardInverse = Mathf.Pow(chanceRewardInverse, numPulls);

        // Calculate overallRewardChance
        overallRewardChance = 1.0f - overallRewardInverse;

        // Display overallRewardChance to the console
        Debug.Log("overallRewardChance: " + overallRewardChance);
    }
    }

    // Update is called once per frame
    //void Update()
    