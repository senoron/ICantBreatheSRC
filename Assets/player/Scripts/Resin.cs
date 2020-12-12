using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resin : MonoBehaviour
{
    [SerializeField] private float resinDamage = 10f;
    [SerializeField] private float resinSpeed = 5f;
    Vector3 movement;
    Vector3 position;
    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        position = transform.position;
        movement = new Vector3(0, resinSpeed * Time.deltaTime, 0);
        position += transform.rotation * movement;
        transform.position = position;
    }

    public float GetResinDamage()
    {
        return resinDamage;
    }
}    
