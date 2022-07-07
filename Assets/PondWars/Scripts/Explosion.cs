/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using System.Collections;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float resetDelay;
    Transform parent;
    private void Awake()
    {
        parent = this.transform.parent;
    }

    private void OnEnable()
    {
        transform.parent = parent.parent;
        StartCoroutine(DestroyDelay());
    }

    IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(resetDelay);
        transform.parent = parent;
        transform.SetPositionAndRotation(parent.position, parent.rotation);
        gameObject.SetActive(false);
    }
}
