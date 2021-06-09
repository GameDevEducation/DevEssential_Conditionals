using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsDemo2 : MonoBehaviour
{
    public int CharacterHealth = 100;
    public int CharacterFoodLevel = 0;
    public int CharacterHungerLevel = 0;

    public int MaxHealthThreshold = 100;
    public int LowHealthThreshold = 50;
    public int IsHungryThreshold = 50;
    public int IsSuperHungryThreshold = 75;

    bool HasShownHealthTutorial = false;
    bool HasShownThingsAreBadTutorial = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int desireForFood = 0;

        // // Set the desireForFood based on hunger level [Version 1]
        // if (CharacterHungerLevel > IsSuperHungryThreshold)
        //     desireForFood = 10;
        // else if (CharacterHungerLevel > IsHungryThreshold)
        //     desireForFood = 5;
        // else
        //     desireForFood = 1;

        // Set the desireForFood based on hunger level [Version 2 - Ternary Operator]
        desireForFood = (CharacterHungerLevel > IsSuperHungryThreshold) ? 10 : ((CharacterHungerLevel > IsHungryThreshold) ? 5 : 1);

        Debug.Log("Desire for food is " + desireForFood);

        // check if health is below low health threshold
        if (CharacterHealth < LowHealthThreshold)
        {
            Debug.Log("Health Low!");

            // do we have food?
            if (CharacterFoodLevel > 0)
                Debug.Log("Eat food now please!");

            // Debug.Log("Not part of food level check");
        }
        else if ((HasShownHealthTutorial == false) && (CharacterHealth < MaxHealthThreshold))
        {
            Debug.Log("Eating food will recover health!");

            HasShownHealthTutorial = true;
        }
        else // runs the block below if the first condition (CharacterHealth < LowHealthThreshold) is not met/true
        {
            // do we have food and we're hungry
            if ((CharacterFoodLevel > 0) && (CharacterHungerLevel > IsHungryThreshold))
            {
                Debug.Log("Hungry. Eat now please!");
            }
        }

        // if low on food or low on health display a warning
        if ((HasShownThingsAreBadTutorial == false) && ((CharacterFoodLevel < 10) || (CharacterHealth < 10)))
        {
            Debug.Log("This is probably really bad");

            HasShownThingsAreBadTutorial = true;
        }
    }
}
