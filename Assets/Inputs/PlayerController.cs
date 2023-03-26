using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Controls playerInput;
    public Transform cameraMain;
    public Transform freelookCameraTransform;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField]
    private float playerSpeed = 2.0f;
    
    [SerializeField]
    private float gravityValue = -9.81f;
    [SerializeField]
    private float rotationSpeed = 4f;

    private Transform child;

    private void Awake()
    {
        playerInput = new Controls();
        controller = GetComponent<CharacterController>();
        child = GetComponent<Transform>();
        freelookCameraTransform = GetComponent<Transform>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    

    private void Start()
    {
        cameraMain = Camera.main.transform;
        child = transform.GetChild(0).transform;
    }

    void Update()
    {
        

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movementInput = playerInput.Map.Move.ReadValue<Vector2>();
        
     

        Vector3 move = (freelookCameraTransform.forward * movementInput.y) + (freelookCameraTransform.right * movementInput.x);
        
        controller.Move(move * Time.deltaTime * playerSpeed);


        if (Time.timeSinceLevelLoad < 0.1f)
        {
            movementInput = Vector2.zero;
        }


        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        if(movementInput != Vector2.zero)
        {
            Quaternion rotation = Quaternion.Euler(new Vector3(child.localEulerAngles.x, freelookCameraTransform.localEulerAngles.y, child.localEulerAngles.z));
            child.rotation = Quaternion.Lerp(child.rotation, rotation, Time.deltaTime * rotationSpeed);
            child.rotation = Quaternion.LookRotation(move, Vector3.up);
            transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * movementInput.x);


        }
    }
}
