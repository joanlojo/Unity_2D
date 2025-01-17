﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ENTICourse.IK
{

    public class RobotJoints : MonoBehaviour
    {

        [Header("Joint Limits")]
        // A single 1, which is the axes of movement
        public Vector3 Axis;
        public Our_Vector3 axis = new Our_Vector3(0, 0, 0);
        public float MinAngle;
        public float MaxAngle;

        [Header("Initial position")]
        // The offset at resting position
        //[ReadOnly]
        public Vector3 StartOffset;
        public Our_Vector3 startOffset = new Our_Vector3(0, 0, 0);
        // The initial one
        //[ReadOnly]
        public Vector3 ZeroEuler;
        public Our_Vector3 zeroEuler = new Our_Vector3(0, 0, 0);



        [Header("Movement")]
        // It lerps the speed to zero, from this distance
        [Range(0, 1f)]
        public float SlowdownThreshold = 0.5f;
        [Range(0, 360f)]
        public float Speed = 1f; // Degrees per second




        void Awake()
        {
            zeroEuler.x = transform.localEulerAngles.x;
            zeroEuler.y = transform.localEulerAngles.y;
            zeroEuler.z = transform.localEulerAngles.z;
            startOffset.x = transform.localPosition.x;
            startOffset.y = transform.localPosition.y;
            startOffset.z = transform.localPosition.z;
            axis.x = Axis.x;
            axis.y = Axis.y;
            axis.z = Axis.z;

            ZeroEuler.x = zeroEuler.x;
            ZeroEuler.y = zeroEuler.y;
            ZeroEuler.z = zeroEuler.z;
            StartOffset.x = startOffset.x;
            StartOffset.y = startOffset.y;
            StartOffset.z = startOffset.z;
        }

        // Update is called once per frame
        void Update()
        {

        }


        // Try to move the angle by delta.
        // Returns the new angle.
        public float ClampAngle(float angle, float delta = 0)
        {
            return Mathf.Clamp(angle + delta, MinAngle, MaxAngle);
        }

        // Get the current angle
        public float GetAngle()
        {
            float angle = 0;
            if (axis.x == 1) angle = transform.localEulerAngles.x;
            else
            if (axis.y == 1) angle = transform.localEulerAngles.y;
            else
            if (axis.z == 1) angle = transform.localEulerAngles.z;

            return angle;
        }
        public float SetAngle(float angle)
        {
            //angle = ClampAngle(angle);
            if (axis.x == 1)
            {
                transform.localEulerAngles = new Vector3(angle, 0, 0); //arregalr esto
            }
            else if (axis.y == 1)
            {
                transform.localEulerAngles = new Vector3(0, angle, 0);
            }
            else if (axis.z == 1)
            {
                transform.localEulerAngles = new Vector3(0, 0, angle);
            }

            return angle;
        }



        // Moves the angle to reach 
        public float MoveArm(float angle)
        {
            return SetAngle(angle);
        }

        private void OnDrawGizmos()
        {
            Debug.DrawLine(transform.position, transform.parent.position, Color.red);
        }
    }
}