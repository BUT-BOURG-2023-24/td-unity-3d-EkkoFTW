using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveByVelovity : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody body = null;
    public InputActionReference moveInputRef = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputMovment = moveInputRef.action.ReadValue<Vector2>();
        body.velocity = new Vector3(inputMovment.x * speed, body.velocity.y, inputMovment.y * speed);
    }
}
