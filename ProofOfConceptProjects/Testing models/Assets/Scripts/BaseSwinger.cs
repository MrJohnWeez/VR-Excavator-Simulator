using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSwinger : MonoBehaviour
{
    public float torque;
    public Rigidbody rb;
    bool addingTorque;
    bool addingReverseTorque;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Keypad9))
        {
            addingTorque = true;
            addingReverseTorque = false;
        }
        else if (Input.GetKey(KeyCode.Keypad3))
        {
            addingTorque = false;
            addingReverseTorque = true;
        }
        else
        {
            addingTorque = false;
            addingReverseTorque = false;
        }
    }

    void FixedUpdate()
    {
        if (addingTorque)
        {
            StopAllCoroutines();
            rb.isKinematic = false;
            rb.AddTorque(transform.up * torque);
        }
        else if (addingReverseTorque)
        {
            StopAllCoroutines();
            rb.isKinematic = false;
            rb.AddTorque(transform.up * -torque);
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            StartCoroutine(WaitThenKinematic());
        }
    }

    IEnumerator WaitThenKinematic()
    {
        yield return new WaitForSeconds(.35f);
        rb.isKinematic = true;
    }
}
