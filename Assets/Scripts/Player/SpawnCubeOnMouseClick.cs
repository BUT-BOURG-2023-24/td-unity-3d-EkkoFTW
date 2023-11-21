using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class SpawnCubeOnMouseClick : MonoBehaviour
{
    public LayerMask groundLayer;
    public GameObject toSpawnObject = null;
    public InputActionReference clickAction = null;
    public float spawnHeightOffset = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnEnable()
    {
        clickAction.action.performed += OnMouseClicked;
        EnhancedTouch.TouchSimulation.Enable();
        EnhancedTouch.EnhancedTouchSupport.Enable();
        EnhancedTouch.Touch.onFingerDown += OnFingerDown;

    }

    public void OnDisable()
    {
        clickAction.action.performed -= OnMouseClicked;
        EnhancedTouch.Touch.onFingerDown -= OnFingerDown;
        EnhancedTouch.TouchSimulation.Disable();
        EnhancedTouch.EnhancedTouchSupport.Disable();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnFingerDown(EnhancedTouch.Finger finger)
    {
        spawnEntity(finger.screenPosition);
    }

    private void OnMouseClicked(InputAction.CallbackContext context)
    {
        spawnEntity(Input.mousePosition);
    }

    private void spawnEntity(Vector2 screenPosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 1000f, groundLayer))
        {
            Vector3 spawnPoint = hitInfo.point;
            spawnPoint.y += spawnHeightOffset;
            //Vector3 defaultSpawn = spawnPoint;
            Instantiate(toSpawnObject, spawnPoint, Quaternion.identity);
            /*
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    spawnPoint.x = defaultSpawn.x + i;
                    spawnPoint.z = defaultSpawn.z + j;
                    Instantiate(toSpawnObject, spawnPoint, Quaternion.identity);
                }
            }
            */
        }
    }
}

