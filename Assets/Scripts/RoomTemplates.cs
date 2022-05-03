using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class RoomTemplates : MonoBehaviour
{

    #region Rooms 
    #region Arrays

    public float ShiftAmount; 
    public GameObject[] bottomRooms;
 
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;
    #endregion
    public GameObject closedRoom;
    public GameObject entryRoom;
    [SerializeField] private GameObject key;
    #endregion

    [HideInInspector] public bool keySpawned = false;

    //public int xSize;
    //public int ySize;
    //private Vector2 roomSize; 
    [HideInInspector] public List<GameObject> rooms;
    [HideInInspector] public List<GameObject> WallSpawnPoints;
    public float waitTime;
    [HideInInspector] public float startWaitTime;
    [HideInInspector] public bool _spawnedBoss;
    public GameObject boss;
    private void Awake()
    {
        startWaitTime = waitTime;
    }
    void SpawnKey()
    {
        
            int spawnIndex = Random.Range(0, rooms.Count -1);
            Instantiate(key, rooms[spawnIndex].transform.position, transform.rotation);
        

    }
    private void Update()
    {
        
        

        if (waitTime <= 0 && _spawnedBoss == false)
        {
            Instantiate(boss, WallSpawnPoints[WallSpawnPoints.Count - 1].transform.position, WallSpawnPoints[WallSpawnPoints.Count - 1].transform.rotation);
            _spawnedBoss = true;
            
        }

        if(waitTime <= 0 && keySpawned == false)
        {
            SpawnKey();
            keySpawned = true;
        }
        else
        {
            waitTime -= Mathf.Clamp(waitTime, 0, Time.deltaTime);
        }
    }
}
