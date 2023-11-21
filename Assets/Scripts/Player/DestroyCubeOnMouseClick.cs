using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyCubeOnMouseClick : MonoBehaviour
{
    public LayerMask groundLayer;
    public GameObject toDestroyObject = null;
    public InputActionReference clickAction = null;
    public void OnEnable()
    {
        clickAction.action.performed += OnMouseClicked;
    }

    public void OnDisable()
    {
        clickAction.action.performed -= OnMouseClicked;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseClicked(InputAction.CallbackContext context)
    {
        Debug.Log("mouse clicked");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 1000f, groundLayer))
        {
            if (hitInfo.collider.tag == toDestroyObject.tag)
            {
                Destroy(hitInfo.collider.gameObject);
            }
        }
    }


}
