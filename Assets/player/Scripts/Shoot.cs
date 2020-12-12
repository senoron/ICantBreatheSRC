using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float ShootColldown = 0f;
    [SerializeField] private float ShootDelay = 0.5f;
    [SerializeField] private GameObject ResinBullet;
    float minusAngle = 90f;

    private void Update()
    {
        LookAtMouse();
        ShootResin();
    }

    void LookAtMouse()
    {
        Vector3 mousePos = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg - minusAngle;
        Quaternion desRot = Quaternion.Euler(0, 0, angle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desRot, 360);
    }

    void ShootResin()
    {
        ShootColldown -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0) && ShootColldown <= 0)
        {
            Debug.Log("Test");
            ShootColldown = ShootDelay;
            Instantiate(ResinBullet, transform.position, transform.rotation);
        }
    }
}
