using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    int currentHealth = 10;
    int startingHealth = 10;
    [SerializeField] Image Enemyhealth;

    private void Start()
    {
        currentHealth = startingHealth;
    }
    public void Hurt(float amount)
    {
        currentHealth -= (int)amount;
        UpdateHealthImage();
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            print("Enemigo muerto, abondo pa mi huerto");
        }
    }

    void UpdateHealthImage()
    {
        Enemyhealth.fillAmount = (1.0f * currentHealth / startingHealth);
    }
}