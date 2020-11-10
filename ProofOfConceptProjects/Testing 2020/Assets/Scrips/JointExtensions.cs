using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JointExtensions
{
    public struct FixedJointData
    {
        public Rigidbody connectedBody;
        public float breakForce;
        public float breakTorque;
        public bool enableCollision;
        public bool enablePreprocessing;
        public float massScale;
        public float connectedMassScale;
    }

    public static FixedJointData GetJointData(this FixedJoint inFixedJoint)
    {
        JointExtensions.FixedJointData data = new JointExtensions.FixedJointData();

        data.connectedBody = inFixedJoint.connectedBody;
        data.breakForce = inFixedJoint.breakForce;
        data.breakTorque = inFixedJoint.breakTorque;
        data.enableCollision = inFixedJoint.enableCollision;
        data.enablePreprocessing = inFixedJoint.enablePreprocessing;
        data.massScale = inFixedJoint.massScale;
        data.connectedMassScale = inFixedJoint.connectedMassScale;

        return data;
    }

    public static void SetJointData(this FixedJoint inFixedJoint, FixedJointData jointData)
    {
        inFixedJoint.connectedBody = jointData.connectedBody;
        inFixedJoint.breakForce = jointData.breakForce;
        inFixedJoint.breakTorque = jointData.breakTorque;
        inFixedJoint.enableCollision = jointData.enableCollision;
        inFixedJoint.enablePreprocessing = jointData.enablePreprocessing;
        inFixedJoint.massScale = jointData.massScale;
        inFixedJoint.connectedMassScale = jointData.connectedMassScale;
    }
}
