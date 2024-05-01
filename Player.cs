using UnityEngine;

public class Player : MonoBehaviour //defines class Player
//MonoBehaviour is a base class for Unity scripts
{
    public Rigidbody2D rb; //Rigidbody2D component attached to the GameObject
    public Transform groundCheck;
    public float groundCheckRadius; 
    public LayerMask whatIsGround; //LayerMask that defines which layers represent ground
    private bool onGround; //boolean flag indicating whether the player is currently on the ground

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Rigidbody2D component attached to the GameObject
        // rigidbody2d is used to simulate 2D physics interactions
    }

    // Update is called once per frame
    void Update()
    {
        onGround = false; 
        rb.velocity = new Vector2(3, rb.velocity.y); //sets x component of the Rigidbody2D's velocity to 3
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        //checks if there are colliders overlapping with the defined radius
        //and if those colliders belong to the layer specified in whatIsGround
        // If so onGround is set to true

    // Jump logic
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 6);
        }
        //if the Space key is pressed and onGround is true,
        //sets the y component of the Rigidbody2D's velocity to 6
    }   
    }
