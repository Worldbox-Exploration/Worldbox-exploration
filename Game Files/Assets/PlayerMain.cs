using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{

    public float health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    public void Damage(float damage)
    {
        health -= damage;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
