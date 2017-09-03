using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public LayerMask groundMask;
    public LayerMask enemyMask;
    public float speed = 0.5f;
    private Rigidbody2D playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>().focus = gameObject;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        var hAxis = Input.GetAxis("Horizontal");
        var vAxis = Input.GetAxis("Vertical");

        if (hAxis > 0)
            playerRigidbody.AddForce(new Vector2(speed, 0f), ForceMode2D.Force);
        else if (hAxis < 0)
            playerRigidbody.AddForce(new Vector2(-speed, 0f), ForceMode2D.Force);
        if (vAxis > 0)
            playerRigidbody.AddForce(new Vector2(0f, speed), ForceMode2D.Force);
        else if(vAxis < 0)
            playerRigidbody.AddForce(new Vector2(0f, -speed), ForceMode2D.Force);

    }
}
