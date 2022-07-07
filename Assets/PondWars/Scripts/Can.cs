/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;

public class Can : MonoBehaviour
{
    CanManager control;
    public bool hit = false;
    private void Awake()
    {
        control = FindObjectOfType<CanManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hit == false)
        {
            hit = true;
            control.hit.Add(this);
        }
    }
}
