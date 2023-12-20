/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class LeftGrab : MonoBehaviour
{
    public string grabbableTag = "LeftGrabbable";
    public float throwForce = 7f;

    private GameObject grabbed = null;
    private Vector3 grabbedOffset = Vector3.zero;
    private Vector3 lastControllerPosition;
    private bool isGrabbable = false;
    public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        lastControllerPosition = this.transform.position;
        controller.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // if (OVRInput.GetDown(OVRInput.Button.Three)) // Button X
        if (OVRInput.Get(OVRInput.Button.Three))
        {
            isGrabbable = !isGrabbable;
        }

        if (grabbed != null) // holding the object
        // if (isGrabbable)
        {
            
            // if (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) < 0.05f) // if clicked trigger very slightly - released
            if (!isGrabbable)
            {
                //trigger relased
                //grabbed.GetComponent<Rigidbody>().isKinematic = false;
                Rigidbody grabbedRigidbody = grabbed.GetComponent<Rigidbody>();
                grabbedRigidbody.isKinematic = false;

                *//*Vector3 throwVelocity = (this.transform.position - lastControllerPosition) * throwForce;
                grabbedRigidbody.velocity = throwVelocity;*//*
                grabbed.transform.position = new Vector3(2.99600005f, 0.758000016f, 1.21700001f);
                const float Y = 90.2745209f;
                Quaternion newRotation = Quaternion.Euler(0f, Y, 0f); // Create a new rotation quaternion with the desired y-axis rotation

                grabbed.transform.rotation = newRotation;
                // grabbed.transform.rotation = new Vector3(x: 0.0f, y: Y, z: 0.0f);
                grabbed = null;

                controller.SetActive(true);
            }
            else
            {
                // grabbed.transform.position = this.transform.position + grabbedOffset;
                grabbed.transform.position = this.transform.position;
                grabbed.transform.rotation = this.transform.rotation;

            }
            lastControllerPosition = this.transform.position;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (grabbed == null) // not - holding or released
        {
            // if (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) > 0.9f && other.gameObject.tag == grabbableTag)
            if (isGrabbable && other.gameObject.tag == grabbableTag)
            {
                grabbed = other.gameObject;
                grabbedOffset = grabbed.transform.position - this.transform.position; // here this refers to controller, subtracting current object position(this) with initial object position(grabbed) and putting it in grabbedOffset, this grabbedOffset is added to this.transform in update function

                grabbed.GetComponent<Rigidbody>().isKinematic = true;

                controller.SetActive(false);
            }
        }
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGrab : MonoBehaviour
{
    public string grabbableTag = "LeftGrabbable";
    public float throwForce = 7f;

    private GameObject grabbed = null;
    private Vector3 grabbedOffset = Vector3.zero;
    private Vector3 lastControllerPosition;
    private bool isGrabbable = false;
    public GameObject controller;

    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        lastControllerPosition = this.transform.position;
        controller.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // if (OVRInput.GetDown(OVRInput.Button.Three)) // Button X
        if (OVRInput.Get(OVRInput.Button.Three))
        {
            isGrabbable = !isGrabbable;
        }

        if (grabbed != null) // holding the object
        // if (isGrabbable)
        {

            // if (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) < 0.05f) // if clicked trigger very slightly - released
            if (!isGrabbable)
            {
                //trigger relased
                //grabbed.GetComponent<Rigidbody>().isKinematic = false;
                Rigidbody grabbedRigidbody = grabbed.GetComponent<Rigidbody>();
                grabbedRigidbody.isKinematic = false;

                /*Vector3 throwVelocity = (this.transform.position - lastControllerPosition) * throwForce;
                grabbedRigidbody.velocity = throwVelocity;*/
                grabbed.transform.position = new Vector3(2.99600005f, 0.758000016f, 1.21700001f);
                const float Y = 90.2745209f;
                Quaternion newRotation = Quaternion.Euler(0f, Y, 0f); // Create a new rotation quaternion with the desired y-axis rotation

                grabbed.transform.rotation = newRotation;
                // grabbed.transform.rotation = new Vector3(x: 0.0f, y: Y, z: 0.0f);
                grabbed = null;

                controller.SetActive(true);
            }
            else // holded the controller
            {
                // grabbed.transform.position = this.transform.position + grabbedOffset;
                grabbed.transform.position = this.transform.position;
                grabbed.transform.rotation = this.transform.rotation;

                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                // if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) // Primary trigger click
                // if (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) > 0.9f) // LIndexTrigger press
                {
                        ShootBullet();
                }

            }
            lastControllerPosition = this.transform.position;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (grabbed == null) // not - holding or released
        {
            // if (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) > 0.9f && other.gameObject.tag == grabbableTag)
            if (isGrabbable && other.gameObject.tag == grabbableTag)
            {
                grabbed = other.gameObject;
                grabbedOffset = grabbed.transform.position - this.transform.position; // here this refers to controller, subtracting current object position(this) with initial object position(grabbed) and putting it in grabbedOffset, this grabbedOffset is added to this.transform in update function

                grabbed.GetComponent<Rigidbody>().isKinematic = true;

                controller.SetActive(false);
            }
        }
    }

    void ShootBullet()
    {
        if (bulletPrefab != null)
        {
            // Create a new bullet at the gun's position and rotation
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // Get the Rigidbody component of the bullet
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

            if (bulletRigidbody != null)
            {
                // Set the velocity of the bullet to move it forward
                bulletRigidbody.velocity = transform.forward * bulletSpeed;
            }
        }
    }

}