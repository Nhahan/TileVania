using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = new Vector2 (moveSpeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Platform")
        {
            moveSpeed = -moveSpeed;
            FlipEnemy();
        }
    }

    void FlipEnemy()
    {
        transform.localScale = new Vector2 (-Mathf.Sign(rigidBody.velocity.x), 1f);
    }
}
