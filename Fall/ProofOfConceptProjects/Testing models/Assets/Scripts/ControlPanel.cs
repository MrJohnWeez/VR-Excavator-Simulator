using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : MonoBehaviour
{
    public GameObject rotationLever;
    public GameObject baseLever;
    public GameObject forearmLever;
    public GameObject bucketLever;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            rotationLever.transform.localPosition += new Vector3(0, 0.2f, 0);
        }
        else if(Input.GetKeyUp(KeyCode.Keypad3))
        {
            rotationLever.transform.localPosition -= new Vector3(0, 0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            rotationLever.transform.localPosition += new Vector3(0, -0.2f, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Keypad9))
        {
            rotationLever.transform.localPosition -= new Vector3(0, -0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            bucketLever.transform.localPosition += new Vector3(0, 0.2f, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            bucketLever.transform.localPosition -= new Vector3(0, 0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            bucketLever.transform.localPosition += new Vector3(0, -0.2f, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            bucketLever.transform.localPosition -= new Vector3(0, -0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            baseLever.transform.localPosition += new Vector3(0, 0.2f, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            baseLever.transform.localPosition -= new Vector3(0, 0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            baseLever.transform.localPosition += new Vector3(0, -0.2f, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Keypad8))
        {
            baseLever.transform.localPosition -= new Vector3(0, -0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            forearmLever.transform.localPosition += new Vector3(0, 0.2f, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            forearmLever.transform.localPosition -= new Vector3(0, 0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            forearmLever.transform.localPosition += new Vector3(0, -0.2f, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            forearmLever.transform.localPosition -= new Vector3(0, -0.2f, 0);
        }
    }
}
