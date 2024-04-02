using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    float speed = 15;
    [SerializeField] float playerBulletDamage;

    public void Shoot(Vector3 direction)
    {
        Rigidbody2D rbBala = gameObject.GetComponent<Rigidbody2D>();

        rbBala.velocity = direction * speed;
    }
    public void bulletShoot(Vector3 directionToMouse, float speed)
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = directionToMouse * speed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyStats enemyHealth = collision.gameObject.GetComponent<EnemyStats>();
            enemyHealth.Hurt(playerBulletDamage);
            Destroy(gameObject);
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        EnemyStats enemyHealth = collision.gameObject.GetComponent<EnemyStats>();
    //        enemyHealth.Hurt(1);
    //        print("Awww me has dado");

    //        Destroy(gameObject);
    //    }

    //}
}