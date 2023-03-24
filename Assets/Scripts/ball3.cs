using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball3 : MonoBehaviour
{
    protected Joystick joystick;
    protected Joybutton joybutton;

    protected bool jump;
    public int speed =3;
    private Rigidbody rb;
    [Range(1, 10)]
    public float jumpVelocity;
    private bool isGrounded;


    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        float movementHorizontal = joystick.Horizontal * 3f + Input.GetAxis("Horizontal") * 3f;
        float movementVertical = joystick.Vertical * 3f + Input.GetAxis("Vertical") * 3f;


        if (!jump && (joybutton.Pressed && isGrounded==true ))
        {
            rb.velocity = Vector3.up * jumpVelocity;
            isGrounded = false;

        }
        if (jump && !joybutton.Pressed )
        {
            jump = false;
        }
        Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);
        rb.AddForce(movement * speed);
    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }

}
