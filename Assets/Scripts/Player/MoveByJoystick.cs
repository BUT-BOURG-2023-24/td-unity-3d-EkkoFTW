using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByJoystick : MonoBehaviour
{
    public Joystick Joystick = null;
    public float speed = 10.0f;
    public Rigidbody body = null; 
    public Animator animator = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputMovement = Joystick.Direction;
        body.velocity = new Vector3(inputMovement.x * speed, body.velocity.y, inputMovement.y * speed);
        if (animator != null)
        {
            animator.SetBool("isGrounded", true);
            animator.SetFloat("Speed", inputMovement.magnitude*speed);
        }
    }
}
