using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float movementSpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        // Joystick movement
        Vector2 movement = new Vector2(movementSpeed, movementSpeed);
        movement *= OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        movement *= Time.deltaTime;
        transform.Translate(new Vector3(movement.x, 0.0f, movement.y));


    }
}