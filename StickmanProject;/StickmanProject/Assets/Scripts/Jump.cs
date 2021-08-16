using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpforce;
    public Rigidbody2D Body;
    public Transform groundCheck;
    public bool isGrounded;
    public float radius;
    public LayerMask Ground;


    void Start()
    {






        isGrounded = false;
    }
    void Update()
    {


        Physics2D.OverlapCircle(groundCheck.position, radius, Ground);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {

            Body.velocity = Vector2.up * jumpforce;
        }
        else
        {
            return;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isGrounded = false;
    }
}