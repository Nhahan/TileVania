using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // 넣어주자!

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    Vector2 moveInput;
    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Run()
    {
        Vector2 playerVelocity = New Vector2 (moveInput.x * speed, 0);
        rigidBody.velocity = playerVelocity;
    }

    void FlipSprite()
    {
        bool hasHorizontalSpeed = Mathf.Abs(rigidBody.velocity.x) > Mathf.Epsilon;
        // Mathf.Abs는 절대값을 반환하고, Mathf.Epsilon은 0에 가까운 수인데 그냥 0이라고 생각해도 무방하다.

        if (hasHorizontalSpeed)
        {
            transform.localScale = new Vector2 (Mathf.Sign(rigidBody.velocity.x), 1f);
            // Mathf.Sign()은 부호를 반환한다.
        }
    }
}
