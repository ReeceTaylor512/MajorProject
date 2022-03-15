using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    [SerializeField] private int openingDirection;

    private RoomTemplates templates;
    private RoomProperties properties; 

    private int rand;
    private bool spawned = false;

    private float waitTime = 4f;

    
    private void Start()
    {
        Destroy(gameObject, waitTime);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        properties = GameObject.FindGameObjectWithTag("RoomProperties").GetComponent<RoomProperties>();

        switch (properties.roomSize)
        {
            case 1:
                Invoke("SpawnRoomSize1", 0.1f);
                break;
            case 2:
                Invoke("SpawnRoomSize2", 0.1f);
                break;
            case 3:
                Invoke("SpawnRoomSize3", 0.1f);
                break;
        }
       
    }
    void SpawnRoomSize1()
    {
        if (spawned == false && templates.Rooms.Count < properties.maxNumRooms)
        {
            switch (openingDirection)
            {
                case 1:
                    rand = Random.Range(0, templates.bottomRooms.Length);
                    Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                    break;
                case 2:
                    rand = Random.Range(0, templates.topRooms.Length);
                    Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
                    break;
                case 3:
                    rand = Random.Range(0, templates.leftRooms.Length);
                    Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                    break;
                case 4: 
                    rand = Random.Range(0, templates.rightRooms.Length);
                    Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                    break;
            }          
            spawned = true;
        }
    }
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            if (other.GetComponent<RoomSpawner>().spawned == false && spawned == false)
            {
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
           
            spawned = true; 
                
        
    }
}
