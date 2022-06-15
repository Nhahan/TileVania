using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rigidBody;
    PlayerMovement player;
    float bulletSpeed;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        bulletSpeed = player.transform.localScale.x * 5f;
    }

    void Update()
    {
        rigidBody.velocity = new Vector2 (bulletSpeed, 0);
        transform.Rotate(0, 0, -70 * 1.25f * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if (other.tag != "Player" && other.tag != "Bullet")
        {
            Destroy(gameObject);
        }
    }

    float GenerateFloat()
    {
        System.Random rnd = new System.Random();
        return (float)rnd.Next(-2, 2) + 1f;
    }
}
