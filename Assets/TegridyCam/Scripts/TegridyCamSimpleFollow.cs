/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
namespace Tegridy.Cam
{
    public class TegridyCamSimpleFollow : MonoBehaviour
{
    public GameObject cameraHolder;
    public GameObject target;
    public Vector3 offset;

    public bool followX;
    public bool followY;
    public bool followZ;
    public bool lookAt;

    private void Start()
    {
        if (followX || followY || followZ) cameraHolder.transform.position = offset;
    }

    void LateUpdate()
    {
        if(lookAt) cameraHolder.transform.LookAt(target.transform.position);

        Vector3 newPos = cameraHolder.transform.position;
        if (followX) newPos.x = target.transform.position.x + offset.x;
        if (followY) newPos.y = target.transform.position.y + offset.y;
        if (followZ) newPos.z = target.transform.position.z + offset.z;



        cameraHolder.transform.position = newPos;
    }
}
}