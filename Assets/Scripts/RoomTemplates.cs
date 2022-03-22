using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoomTemplates : MonoBehaviour
{

    #region Rooms 
    #region Arrays
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;
    #endregion
    public GameObject closedRoom;
    public GameObject entryRoom;
    #endregion

    //public int xSize;
    //public int ySize;
    //private Vector2 roomSize; 
    public List<GameObject> Rooms; 

    

   
    //public void ChangeSize()
    //{
    //    roomSize = new Vector2(xSize, ySize); //Sets the roomSize Vector3 to size (which uses the slider value from RoomProperties),
    //                                              //this is because Vector3 cannot be used with switch statements 
    //    switch (xSize)
    //    {
    //        //Case 1: if size is set to 1 then the scale of all rooms will be roomSize which is 1x1x1
    //        case 1:
    //            entryRoom.transform.localScale = roomSize;
    //            for (int i = 0; i < 3; i++)
    //            {

    //                bottomRooms[i].transform.localScale = roomSize;
    //                topRooms[i].transform.localScale = roomSize;
    //                leftRooms[i].transform.localScale = roomSize;
    //                rightRooms[i].transform.localScale = roomSize;
    //            }                
    //            break;
    //            //Case 2: if size is set to 2 then the scale of all rooms will be roomSize which is 2x2x2
    //        case 2:
                
    //            entryRoom.transform.localScale = roomSize;
    //            for (int i = 0; i < 3; i++)
    //            {

    //                bottomRooms[i].transform.localScale = roomSize;
    //                topRooms[i].transform.localScale = roomSize;
    //                leftRooms[i].transform.localScale = roomSize;
    //                rightRooms[i].transform.localScale = roomSize;
    //            }
    //            break;

    //            //Case 3: if size is set to 3 then the scale of all rooms will be roomSize which is 3x3x3
    //            case 3:
    //            entryRoom.transform.localScale = roomSize;;
    //            for (int i = 0; i < 3; i++)
    //            {

    //                bottomRooms[i].transform.localScale = roomSize;
    //                topRooms[i].transform.localScale = roomSize;
    //                leftRooms[i].transform.localScale = roomSize;
    //                rightRooms[i].transform.localScale = roomSize;
    //            }
    //            break;
    //    }
        
    //}

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
