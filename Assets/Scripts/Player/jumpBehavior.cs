using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class jumpBehavior : MonoBehaviour
{
    public InputActionReference jumpAction = null;
    public Rigidbody body = null;
    public float jumpPower = 300f;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnEnable()
    {
        jumpAction.action.performed += OnJumpInputPressed;
    }

    public void OnDisable()
    {
        jumpAction.action.performed -= OnJumpInputPressed;
    }

    // Update is called once per frame
    void Update()
    {   
    }

    private void OnJumpInputPressed(InputAction.CallbackContext context)
    {
        Jump();
    }

    private void Jump()
    {
        Debug.Log("dzadazdza");
        body.AddForce(Vector3.up*jumpPower);
    }
}

