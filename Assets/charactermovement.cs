using UnityEngine;

public class charactermovement : MonoBehaviour
{
    float horizontalInput;
    float movespeed = 5f;
    float jumpPower = 6f;
    public projectilemovement projectilePrefab;
    public Transform LaunchOffset;
    Rigidbody2D rb;
    bool isjumping = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && !isjumping)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
            isjumping = true;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab, LaunchOffset.position, LaunchOffset.rotation);
        }
    }

    private void FixedUpdate()
    {
        
        rb.linearVelocity = new Vector2(horizontalInput * movespeed, rb.linearVelocity.y);
    }

    private void Reset()
    {
        rb.angularVelocity = 0f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isjumping = false;
    }
}