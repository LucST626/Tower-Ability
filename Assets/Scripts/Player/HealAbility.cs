using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HealAbility : Ability
{
    PlayerHealth PH;

    public override void PlayerTransform(Transform player)
    {

    }

    public override void Trigger(Vector3 direction)
    {
        //PH = GetComponent<PlayerHealth>();
        PH.Heal(5);
        PH.UpdateHealthImage();
        //StartCoroutine(coolDownCouroutine());s
    }
}
