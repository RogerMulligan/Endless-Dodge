using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sp;

    public float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x < Screen.width / 2)
            {
                rb.velocity = Vector2.left * moveSpeed; // move left
                sp.flipX = true; // switch to character viewing left
                
            }
            else
            {
                rb.velocity = Vector2.right * moveSpeed; // switch right
                sp.flipX = false; // switch to character viewing right
            }
        }
    }
}
