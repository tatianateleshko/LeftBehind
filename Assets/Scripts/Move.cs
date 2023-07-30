using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public float jumpforce;
    [SerializeField] GroundCheck groundCheck;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer sprite;

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("IsGoing", true);
        }
        else
        {
            animator.SetBool("IsGoing", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            sprite.flipX = true;
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            
        }
    }
}
