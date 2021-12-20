using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour, IHit
{

    public float health = 100f;

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        sr.color = new Color(1, health/100, health/100);

        if(health <= 0) 
        {
            Destroy(gameObject);
        }
    }

    public void Hit(float damage)
    {
        health -= damage;
    }
}
