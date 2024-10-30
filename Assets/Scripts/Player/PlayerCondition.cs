using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;
    Condition health { get { return uiCondition.health; } }
    Condition stamina { get { return uiCondition.stamina; } }

    // Update is called once per frame
    void Update()
    {
        stamina.Add(stamina.passiveValue * Time.deltaTime);
    }
    public void Heal(float amount)
    {
        health.Add(amount);
    }
    public void UseSp(float amount)
    {
        stamina.Add(amount);
    }
   
}
