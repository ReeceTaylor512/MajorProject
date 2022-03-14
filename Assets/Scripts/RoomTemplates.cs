using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRoom;
    public GameObject entryRoom;
    public List<GameObject> Rooms;


    public float waitTime;
    private bool spawnedBoss;
    public GameObject boss;

   

    private void Update()
    {
        if (waitTime <= 0 && spawnedBoss == false)
        {
            Instantiate(boss, Rooms[Rooms.Count - 1].transform.position, Quaternion.identity);
            spawnedBoss = true; 
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
}
