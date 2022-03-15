using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomProperties : MonoBehaviour
{

   
    [Rename("Maximum Number of Rooms")]
    public int maxNumRooms;

    [Range(1, 3)]
    public int roomSize;   

  
 
   
}
