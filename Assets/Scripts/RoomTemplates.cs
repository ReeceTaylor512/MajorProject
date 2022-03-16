using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoomTemplates : MonoBehaviour
{
    

    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public int size;
    private Vector3 roomSize; 
    public List<GameObject> Rooms; 

    public GameObject closedRoom;
    public GameObject entryRoom;

   
    public void ChangeSize()
    {
        roomSize = new Vector3(size, size, size);
        switch (size)
        {
            case 1:

                entryRoom.transform.localScale = roomSize;
                for (int i = 0; i < 3; i++)
                {
                    
                    bottomRooms[i].transform.localScale = roomSize;
                    //topRooms[i].transform.localScale = roomSize;
                    //leftRooms[i].transform.localScale = roomSize;
                    //rightRooms[i].transform.localScale = roomSize;
        }                
                break;
            case 2:
                
                entryRoom.transform.localScale = roomSize;
                for (int i = 0; i < 3; i++)
                {

                    bottomRooms[i].transform.localScale = roomSize;
                    //topRooms[i].transform.localScale = roomSize;
                    //leftRooms[i].transform.localScale = roomSize;
                    //rightRooms[i].transform.localScale = roomSize;
                }
                break;
                case 3:
                
                entryRoom.transform.localScale = roomSize;;
                for (int i = 0; i < 3; i++)
                {

                    bottomRooms[i].transform.localScale = roomSize;
                    //topRooms[i].transform.localScale = roomSize;
                    //leftRooms[i].transform.localScale = roomSize;
                    //rightRooms[i].transform.localScale = roomSize;
                }
                break;
        }
        
    }


    public float waitTime;
    private bool spawnedBoss;
    public GameObject boss;

   

    private void Update()
    {

        if (waitTime <= 0 && spawnedBoss == false)
        {
            //Instantiate(boss, Rooms[Rooms.Count - 1].transform.position, Quaternion.identity);
            spawnedBoss = true; 
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
}
