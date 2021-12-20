using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float damage = 20f;

    Collider2D collider;
    Animator animator;        

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();

        // collider should be off by default unless triggered by player
        collider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    public virtual void Attack()
    {
        Debug.Log("Attack!");
        animator.SetTrigger("Attack");
        collider.enabled = true;
    }

    // this function is called by the animation when it's attack ends.
    public virtual void EndAttack()
    {
        print("Attack Ended!");
        collider.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        print(col.transform.name);
        IHit hit = col.transform.GetComponent<IHit>();
        if(hit != null) 
            hit.Hit(damage);
        
    }
}
