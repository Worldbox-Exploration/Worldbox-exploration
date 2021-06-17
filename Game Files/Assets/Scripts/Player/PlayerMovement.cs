using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    void Update(){
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

        transform.position = Vector2.MoveTowards(transform.position, transform.position + direction, Time.deltaTime * moveSpeed);
    }
}
