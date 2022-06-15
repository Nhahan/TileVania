using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D rigidBody;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = new Vector2 (moveSpeed, 0f);
    }
}
