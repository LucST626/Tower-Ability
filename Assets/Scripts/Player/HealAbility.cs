using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAbility : Ability
{
    PlayerHealth PH;
    public override void Trigger(Vector3 direction)
    {
        PH = GetComponent<PlayerHealth>();
        PH.Heal(5);
        PH.UpdateHealthImage();
    }
}
