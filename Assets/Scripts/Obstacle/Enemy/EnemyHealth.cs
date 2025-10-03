using UnityEngine;
using System;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    public event Action<EnemyHealth> Dead;

    public int Health { get; set;}
    
    private void Start()
    {
       InitializeHealth(20);
    }

    public void InitializeHealth(int health)
    {
        Health = Mathf.Max(1, Mathf.FloorToInt(health / 30f));
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Dead?.Invoke(this);
            Destroy(gameObject);
        }
    }
}