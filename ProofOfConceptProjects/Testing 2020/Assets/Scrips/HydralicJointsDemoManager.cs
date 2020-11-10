using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydralicJointsDemoManager : MonoBehaviour
{
    public HydralicJoint hydralicJoint;

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            hydralicJoint.SetTargetVelocity(-10);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            hydralicJoint.SetTargetVelocity(10);
        }else
        {
            hydralicJoint.SetTargetVelocity(0);
        }
    }
}
