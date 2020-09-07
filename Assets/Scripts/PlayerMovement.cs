using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    Animator animator;
    public bool isFacingRight = true;
    public bool isPlayer1;
    float horizontal, vertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        else
        {
            horizontal = Input.GetAxis("Horizontal1");
            vertical = Input.GetAxis("Vertical1");
        }

        Vector2 movement = new Vector2(horizontal, vertical) * speed;
        rb.velocity = movement;

        if (isFacingRight == true && horizontal < 0)
        {
            FlipFace();
        }
        else if(isFacingRight == false && horizontal > 0)
        {
            FlipFace();
        }
        animator.SetFloat("speed", Mathf.Abs(horizontal));
    }

    public void FlipFace()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
