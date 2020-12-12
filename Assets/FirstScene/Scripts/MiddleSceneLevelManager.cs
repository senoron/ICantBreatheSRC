using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleSceneLevelManager : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    public float period = 3f;
 
    void Update () {
        if (Time.time > nextActionTime ) {
            nextActionTime += period;
            Application.LoadLevel("Main");

        }
    }
}
