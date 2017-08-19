using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public LayerMask groundMask;
    public LayerMask enemyMask;
    public float speed = 0.5f;
    public float jumpForce;
    private Rigidbody2D playerRigidbody;

	void Start ()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>().focus = gameObject;
	}

	void Update()
    {

    }

	void FixedUpdate ()
    {
        var hAxis = Input.GetAxis("Horizontal");
        var jump = Input.GetButton("Jump");
        var grounded = Physics2D.OverlapCircle(playerRigidbody.position - new Vector2(0f, 1.1f), 0.1f, groundMask) != null;

        if (hAxis > 0.2)
            playerRigidbody.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        else if (hAxis < -0.2)
            playerRigidbody.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);
        else
            playerRigidbody.velocity = new Vector2(Mathf.Lerp(playerRigidbody.velocity.x,0,0.0625f), playerRigidbody.velocity.y);
        
        if (grounded && jump)
            playerRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);


        if(playerRigidbody.rotation != 0)
        {
            playerRigidbody.rotation = 0;
        }
	}
    
    
}
