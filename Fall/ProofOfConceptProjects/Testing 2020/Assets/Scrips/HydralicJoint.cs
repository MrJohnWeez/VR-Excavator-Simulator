using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class HydralicJoint : MonoBehaviour
{
    public float GetTargetVelocity => _hingeJoint.motor.targetVelocity;
    public float GetForce => _hingeJoint.motor.force;

    private HingeJoint _hingeJoint;
    private FixedJoint _fixedJoint;
    private JointExtensions.FixedJointData _fixedJointData;

    void Start()
    {
        _hingeJoint = gameObject.GetComponent<HingeJoint>();

        _fixedJoint = gameObject.GetComponent<FixedJoint>();

        if(!_fixedJoint)
            Debug.LogError("Not FixedJoint component on GameObject " + gameObject.name + " but HydralicJoint depends on it.");

        _fixedJointData = _fixedJoint.GetJointData();
        SetTargetVelocity(0);
    }

    public void SetTargetVelocity(float newVelocity)
    {
        SetTargetVelocityAndForce(newVelocity, GetForce);
    }

    public void SetForce(float newForce)
    {
        SetTargetVelocityAndForce(GetTargetVelocity, newForce);
    }

    public void SetTargetVelocityAndForce(float newVelocity, float newForce)
    {
        if(newVelocity != GetTargetVelocity || newForce != GetForce)
        {
            JointMotor motor = _hingeJoint.motor;
            motor.targetVelocity = newVelocity;
            motor.force = newForce;
            _hingeJoint.motor = motor;
            ForceWasChanged();
        }
    }

    private void ForceWasChanged()
    {
        Debug.Log("Force was changed!");
        if(GetTargetVelocity == 0 && !_fixedJoint)
        {
            _fixedJoint = gameObject.AddComponent<FixedJoint>();
            _fixedJoint.SetJointData(_fixedJointData);
        }
        else if(GetTargetVelocity != 0 && _fixedJoint)
        {
            Destroy(_fixedJoint);
        }
    }

    public void GetFixedJointData()
    {
        // Use this to find out how much force is being applied when a joint is locked
        // _fixedJoint.currentTorque and _fixedJoint.currentForce
        // useful to create an auto release system if hydralicPressure exceeds threashold
        
    }
}
