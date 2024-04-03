using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Ability : ScriptableObject
{
    //[SerializeField] string abilityName;
    protected Transform Player;
    [SerializeField] public float coolDown;
    public float elapsedCoolDown = 0;

    public abstract void Trigger(Vector3 direction);

    public abstract void PlayerTransform(Transform playerTr);
    public IEnumerator coolDownCouroutine()
    {
        while (elapsedCoolDown <= coolDown)
        {
            elapsedCoolDown += Time.deltaTime;
            yield return null;
        }
    }
}
