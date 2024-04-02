using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Shoot : Ability
{
    [SerializeField] GameObject Bullets;
    [SerializeField] float speed;
    [SerializeField] Transform spawnPoint;
    [SerializeField] List<Transform> Spawn;
    
   public override void Trigger(Vector3 direction)
    {
        if(elapsedCoolDown == 0)
        {
            for(int i = 0; i < Spawn.Count; i++)
            {
                GameObject bulletInstance = GameObject.Instantiate
                (Bullets,
                Spawn[i].position,
                Quaternion.identity
                );
                LinearMovement lm = bulletInstance.GetComponent<LinearMovement>();
                lm.bulletShoot(direction, speed);
                Destroy(bulletInstance, 1f);

                lm.Shoot(direction);

            }
            StartCoroutine(coolDownCouroutine());
        }
        else if (elapsedCoolDown >= coolDown)
        {
            elapsedCoolDown = 0;
        }
    }
}