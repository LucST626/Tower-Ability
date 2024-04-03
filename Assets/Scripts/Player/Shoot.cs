using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Shoot : Ability
{
    [SerializeField] GameObject Bullets;
    [SerializeField] float speed;
    [SerializeField] GameObject bulletSpawn;
    public override void PlayerTransform(Transform playerTr)
    {
        Transform spawnPoint = playerTr.Find("BulletSpawn");

        for (int i = 0; i < spawnPoint; i++)
        {

        }
    }

    public override void Trigger(Vector3 direction)
    {
        if(elapsedCoolDown == 0)
        {
                GameObject bulletInstance = GameObject.Instantiate
                (Bullets,
                direction,
                Quaternion.identity
                );
                LinearMovement lm = bulletInstance.GetComponent<LinearMovement>();
                lm.bulletShoot(direction, speed);
                Destroy(bulletInstance, 1f);

                lm.Shoot(direction);
            
                //StartCoroutine(coolDownCouroutine());
        }
        else if (elapsedCoolDown >= coolDown)
        {
            elapsedCoolDown = 0;
        }
    }
}