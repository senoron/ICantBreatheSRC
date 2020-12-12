using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterRoom : MonoBehaviour
{
    public GameObject centerRoom;

    public void SetCenterRoom()
    {
        Instantiate(centerRoom, transform.position, centerRoom.transform.rotation);
    }
}
