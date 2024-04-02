using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    //[SerializeField] string abilityName;
    [SerializeField] public float coolDown;
    public float elapsedCoolDown = 0;

    public abstract void Trigger(Vector3 direction);
    public IEnumerator coolDownCouroutine()
    {
        while (elapsedCoolDown <= coolDown)
        {
            elapsedCoolDown += Time.deltaTime;
            print(elapsedCoolDown);
            yield return null;
        }
    }
}
