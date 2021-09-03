using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{

    public float health;
    [Space]
    public KeyCode mapKey;
    public GameObject map;

    bool mapOpen;

    // Start is called before the first frame update
    void Start()
    {
        map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Map();

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

    public void Map()
    {
        if(Input.GetKeyDown(mapKey))
        {
            mapOpen = !mapOpen;
        }

        if(mapOpen)
            map.SetActive(true);
        else
            map.SetActive(false);
    }
}
