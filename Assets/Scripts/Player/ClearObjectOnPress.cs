using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClearObjectOnPress : MonoBehaviour
{
    public GameObject toDestroyObject = null;
    public InputActionReference clickAction = null;
    public void OnEnable()
    {
        clickAction.action.performed += OnPress;
    }

    public void OnDisable()
    {
        clickAction.action.performed -= OnPress;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnPress(InputAction.CallbackContext context)
    {
        Debug.Log("dzdazdd");
        GameObject[] toDelete = GameObject.FindGameObjectsWithTag(toDestroyObject.tag);
        foreach (GameObject toDeleteObj in toDelete)
        {
            Destroy(toDeleteObj);
        }
    }
}
