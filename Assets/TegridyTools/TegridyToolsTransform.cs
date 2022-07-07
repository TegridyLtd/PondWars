/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
namespace Tegridy.Tools
{
    public static class TransformTools {
        public static void SetZero(GameObject thisObject)
        {
            thisObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        }

        public static float RotateInput(float thisInput, float rotateSpeed, float currentRotation)
        {
            float newVal = currentRotation;
            float rotateAmmount = Time.deltaTime * rotateSpeed;
            if (thisInput > 0) newVal += rotateAmmount;
            else if (thisInput < 0) newVal -= rotateAmmount;
            return newVal;
        }


    }
}