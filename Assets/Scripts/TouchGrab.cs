using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TouchGrab : MonoBehaviour

{

    public string leftGrabbableTag = "LeftGrabbable";

    public string rightGrabbableTag = "RightGrabbable";

    private GameObject grabbedObject = null;

    private Vector3 grabbedOffset = Vector3.zero;

    private Vector3 lastControllerPosition;

    public float throwForce = 5.0f;

    public OVRInput.Controller controller;

    void Start()
    {

        lastControllerPosition = transform.position;

    }

    void Update()

    {

        if (grabbedObject != null)

        {

            if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, controller) < 0.05f)

            {

                ReleaseObject();

            }

            else
            {

                grabbedObject.transform.position = transform.position + grabbedOffset;

            }
        }

        lastControllerPosition = transform.position;

    }

    private void ReleaseObject()

    {

        grabbedObject.GetComponent<Rigidbody>().isKinematic = false;

        Vector3 currentControllerPosition = transform.position;

        Vector3 velocity = (currentControllerPosition - lastControllerPosition) / Time.deltaTime;

        velocity *= throwForce;

        grabbedObject.GetComponent<Rigidbody>().velocity = velocity;

        grabbedObject = null;

    }

    private void OnTriggerStay(Collider other)

    {

        if (grabbedObject == null)

        {

            bool isLeftHand = controller == OVRInput.Controller.LTouch;

            bool isRightHand = controller == OVRInput.Controller.RTouch;

            bool triggerPressed = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, controller) > 0.9f;

            if (triggerPressed && ((isLeftHand && other.gameObject.tag == leftGrabbableTag) ||

                                    (isRightHand && other.gameObject.tag == rightGrabbableTag)))

            {

                GrabObject(other.gameObject);

            }

        }

    }

    private void GrabObject(GameObject obj)

    {

        grabbedObject = obj;

        grabbedOffset = grabbedObject.transform.position - transform.position;

        grabbedObject.GetComponent<Rigidbody>().isKinematic = true;

    }

}
