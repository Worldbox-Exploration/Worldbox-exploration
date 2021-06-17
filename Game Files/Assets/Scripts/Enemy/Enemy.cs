using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float minimumDistanceToMove;
    [Space]
    public Vector2 maximumRange;
    public Vector2 minimumRange;
    [Space]
    public float damage;
    public float health;

    protected Rigidbody2D rb;

    Vector2 movePos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        movePos = GeneratePosition();

        EnemyStart();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    public virtual void EnemyStart()
    {

    }

    public virtual void EnemyMove()
    {
        transform.position = Vector2.Lerp(transform.position, movePos, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, movePos) < minimumDistanceToMove)
        {
            movePos = GeneratePosition();
        }

    }

    Vector2 GeneratePosition()
    {
        return new Vector2(transform.position.x + Random.Range(minimumRange.x, maximumRange.x), transform.position.y + Random.Range(minimumRange.y, maximumRange.y));
    }

    public virtual void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerMain player = other.gameObject.GetComponent<PlayerMain>();

            player.Damage(damage);
        }
    }
}
