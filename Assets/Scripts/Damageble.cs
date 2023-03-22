using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageble : MonoBehaviour
{
    [SerializeField] private float health = 1f;
    public float timeStart = 7;

    private void Update()
    {
        timeStart -= Time.deltaTime;

        if (timeStart <= 0)
        {
            Destroy();
        }
    }

    public void TakeDamage(float Damage)
    {
        health -= Damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Counter.Instance.AddScore();
        Destroy(gameObject);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
