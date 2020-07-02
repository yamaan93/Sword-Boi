
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public float horizontalForce = 200f;
    public float jumpForce = 200f;
    public float maxVelocity = 50f;
    public SpriteRenderer sr;
    bool isGrounded = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        bool jump = false;
        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
        Vector2 horzintalMovement = new Vector2(horizontalForce, 0);
        Vector2 jumpVector = new Vector2(0,jumpForce);
       
        /*SO multiplying forces by Time.FixedDeltaTime is useless because that number is constant
         so you just end up scaling the number down by 0.01 or what ever you have it set to
        */
        //Debug.Log(rb.velocity);

        if (Input.GetKey("d")&& rb.GetPointVelocity(Vector2.zero).x < maxVelocity)
        { 
            rb.AddForce(horzintalMovement );
            sr.flipX = true;

        }
        if (Input.GetKey("a")&& rb.GetPointVelocity(Vector2.zero).x > maxVelocity*-1)
        {
            rb.AddForce(horzintalMovement * -1);
            sr.flipX = false;
        }

        if (jump == true && isGrounded == true) 
        {
           rb.AddForce(jumpVector,ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
    }
    void OnCollisionExit2D(Collision2D col)
    {
        isGrounded = false;
    }

}
