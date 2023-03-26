using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    // Speed of the player character
    public float speed = 10.0f;
    public bool isAccelerating;
    // Reference to the new Input System's action map
    public InputActionAsset inputActions;
    private PlayerInput playerInput;

    

    private void Awake()
    {
        playerInput = new PlayerInput();
        
    }



    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current state of the "Accelerate" action
        //bool isAccelerating = inputActions.GetAction("Accelerate").ReadValue<float>() > 0;
        isAccelerating = inputActions.FindAction("Accelerate").ReadValue<float>() > 0;
        // If the "Accelerate" action is being pressed, move the player character forward
        if (isAccelerating)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
