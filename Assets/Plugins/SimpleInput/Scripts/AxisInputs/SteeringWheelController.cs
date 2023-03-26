using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheelController : MonoBehaviour
{
    // The speed at which the vehicle will turn
    public float turnSpeed = 180.0f;

    // The radius of the steering wheel in pixels
    public float steeringWheelRadius = 100.0f;

    // The pivot point of the steering wheel
    public Vector2 steeringWheelPivot = new Vector2(100, 100);

    // The transform of the vehicle
    public Transform vehicleTransform;

    void Start()
    {
        vehicleTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // Check if the screen is being touched
        if (Input.touchCount > 0)
        {
            // Get the first touch on the screen
            Touch touch = Input.GetTouch(0);

            // Check if the touch is within the radius of the steering wheel
            Vector2 touchPos = touch.position;
            if (Vector2.Distance(touchPos, steeringWheelPivot) < steeringWheelRadius)
            {
                // Calculate the angle of the touch relative to the pivot point of the steering wheel
                float touchAngle = Mathf.Atan2(touchPos.y - steeringWheelPivot.y, touchPos.x - steeringWheelPivot.x) * Mathf.Rad2Deg;

                // Rotate the vehicle based on the angle of the touch
                vehicleTransform.Rotate(0, touchAngle * turnSpeed * Time.deltaTime, 0);
            }
        }
    }
}
