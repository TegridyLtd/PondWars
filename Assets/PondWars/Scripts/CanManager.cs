/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using UnityEngine;

public class CanManager : MonoBehaviour
{
    public Can[] cans;
    public List<Can> hit;
    public void StartUp()
    {
        cans = FindObjectsOfType<Can>();
        hit = new List<Can>();
    }

    public void ResetCans()
    {
        hit = new List<Can>();
        for (int i = 0; i < cans.Length; i++) cans[i].hit = false;
    }
}
