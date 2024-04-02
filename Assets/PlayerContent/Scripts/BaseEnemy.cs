using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    [SerializeField] float health = 500f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Damaged(float damage)
    {
        Debug.Log($"Took {damage} pts of damage");
        health -= damage;
        {
            if (health <= 0 )
            {
                Die();
            }
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }

    protected virtual void Move()
    {

    }
}
