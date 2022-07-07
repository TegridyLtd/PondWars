/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UITurretPrefab : MonoBehaviour
{
    public TextMeshProUGUI pivot;
    public TextMeshProUGUI rotation;
    public TextMeshProUGUI ammo;
    public TextMeshProUGUI ammoQty;
    public TextMeshProUGUI fireMode;
    public TextMeshProUGUI targetMode;
    public UITurretBarrelPrefab barrel;
    [HideInInspector] public UITurretBarrelPrefab[] barrelHolder;

    public int prefabSpacing;


}
