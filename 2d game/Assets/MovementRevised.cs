using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRevised : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float movementSpeed = 40f;
    [SerializeField] private float jumpVelocity = 5f;
    [SerializeField] private LayerMask groundIsWhat;
    [Range(0, .3f)] [SerializeField] private float MovementSmoothing = .05f;

    [SerializeField] private Transform groundCheck;
    [Header("High and low jump Multipliers")]
    [Space]
    [SerializeField] private float fallMultiplier = 2.5f;
    [SerializeField] private float lowJumpMultiplier = 2f;

    const float overlapRadius = .2f;
    private bool onGround;

    private float xMoveAxis;
    private float yMoveAxis;
    private bool jump;
    private Vector3 refVelocity = Vector3.zero;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        xMoveAxis= Input.GetAxisRaw("Horizontal");
        yMoveAxis = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.fixedDeltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.fixedDeltaTime;
        }

        onGround = Physics2D.OverlapCircle(groundCheck.position, overlapRadius, groundIsWhat);
        Vector2 dir = new Vector2(xMoveAxis, yMoveAxis);

        Move(dir * Time.fixedDeltaTime, jump);
        jump = false;

    }
    private void Move(Vector2 dir, bool jump) {
        Vector3 targetVelocity = new Vector2(dir.x * 10f * movementSpeed, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref refVelocity, MovementSmoothing);

        if (onGround && jump)
        {
            onGround = false; 

            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.velocity += Vector2.up * jumpVelocity;
        }
    }
    
}
