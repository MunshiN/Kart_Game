using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


[RequireComponent(typeof(CinemachineFreeLook))]
public class CameraLook : MonoBehaviour
{
    private CinemachineFreeLook cinemachine;

    private Controls playerInput;

    [SerializeField]

    private float lookSpeed = 1;

    private void Awake()
    {
        playerInput = new Controls();
        cinemachine = GetComponent<CinemachineFreeLook>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 delta = playerInput.Map.Look.ReadValue<Vector2>();
        cinemachine.m_XAxis.Value += delta.x * 50* lookSpeed * Time.deltaTime;
        cinemachine.m_YAxis.Value += delta.y * lookSpeed * Time.deltaTime;
    }
}
