using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoomSpawner : MonoBehaviour
{
    public int openingDir;
    // 1 -> bottom
    // 2 -> top
    // 3 -> left
    // 4 -> right 

    private RoomTemplates templates;
    private int rand;
    public bool spawned = false; 

    void Start()
    {
        templates = GameObject.FindWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("SpawnRoms", 0.2f);
    }
    
    void SpawnRoms()
    {
        if (spawned == false)
        {
            if (openingDir == 1)
            {
                rand = Random.Range(0, templates.BottomRooms.Length);
                Instantiate(templates.BottomRooms[rand], transform.position, templates.BottomRooms[rand].transform.rotation);
            }
            else if (openingDir == 2)
            {
                rand = Random.Range(0, templates.TopRooms.Length);
                Instantiate(templates.TopRooms[rand], transform.position, templates.TopRooms[rand].transform.rotation);
            }
            else if (openingDir == 3)
            {
                rand = Random.Range(0, templates.LeftRooms.Length);
                Instantiate(templates.LeftRooms[rand], transform.position, templates.LeftRooms[rand].transform.rotation);
            }
            else if (openingDir == 4)
            {
                rand = Random.Range(0, templates.RightRooms.Length);
                Instantiate(templates.RightRooms[rand], transform.position, templates.RightRooms[rand].transform.rotation);
            }

            spawned = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SP") && other.GetComponent<RoomSpawner>().spawned == true)
        {
            Destroy(gameObject);
        }
    }
}
