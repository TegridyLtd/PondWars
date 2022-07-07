/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;

public class BasicProjectile : MonoBehaviour
{
    public GameObject warHead;

    private void Awake()
    {
        warHead.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        warHead.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
