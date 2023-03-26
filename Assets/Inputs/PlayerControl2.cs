using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControl2 : MonoBehaviour
{
    public InputActionAsset inputActionAsset;
    public InputAction accelerateAction;
    public float accelerationForce = 1000.0f;

    void Start()
    {
        // Get the Accelerate action from the Input Action asset
        accelerateAction = inputActionAsset.FindAction("Accelerate");
    }

    public void OnAccelerateButtonClicked()
    {
        // Trigger the Accelerate action
        accelerateAction.IsPressed();
    }

    void Update()
    {
        // Check if the Accelerate action has been triggered
        if (accelerateAction.triggered)
        {
            // Apply a force in the forward direction to accelerate the player
            GetComponent<Rigidbody>().AddForce(transform.forward * accelerationForce, ForceMode.Impulse);
        }
    }
}

