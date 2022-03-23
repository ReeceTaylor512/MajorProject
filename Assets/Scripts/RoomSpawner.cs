
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class RoomSpawner : MonoBehaviour
{
    [SerializeField] private int openingDirection;

    private int maxNumRooms;

    private RoomTemplates templates;
    private GameObject ClosedRoom; 
    //private RoomProperties properties; 

    private int rand;
    private bool spawned = false;

    private float waitTime = 5f;
    


    private void Start()
    {
        Destroy(gameObject, waitTime);
      
        
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>(); //Find the Room Templates object (object with the room arrays
        Invoke("SpawnRoomSize1", 0.1f);


    }
    void SpawnRoomSize1()
    {
        
        if (spawned == false /*templates.Rooms.Count < properties.maxNumRooms*/)
        {
            switch (openingDirection)
            {
                
                case 1:
                    rand = Random.Range(0, templates.bottomRooms.Length);
                    GameObject o1 = Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                    //Store child 
                    List<GameObject> spawnPoints1 = new List<GameObject>();
                    foreach (Transform o in o1.transform)
                    {
                        spawnPoints1.Add(o.gameObject);
                       //spawnPoints1 = spawnPoints1.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints1.Count(); i++)
                    {
                        if (spawnPoints1[i].GetComponent<RoomSpawner>().openingDirection == 5)
                        {
                            o1.GetComponent<Transform>().transform.localPosition += new Vector3(0, 0.5f, 0);
                         
                        }
                    }
                    
                    break;
                case 2:
                    rand = Random.Range(0, templates.topRooms.Length);
                    GameObject o2 = Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
                    //Store child 
                    List<GameObject> spawnPoints2 = new List<GameObject>();
                    foreach (Transform o in o2.transform)
                    {
                        spawnPoints2.Add(o.gameObject);
                        //spawnPoints2 = spawnPoints2.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints2.Count(); i++)
                    {
                        if (spawnPoints2[i].GetComponent<RoomSpawner>().openingDirection == 6)
                        {
                            o2.GetComponent<Transform>().transform.localPosition -= new Vector3(0, 0.5f, 0);
                            
                        }
                    }
                    break;
                case 3:
                    rand = Random.Range(0, templates.leftRooms.Length);
                    GameObject o3 = Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                    //Store child 
                    List<GameObject> spawnPoints3 = new List<GameObject>();
                    foreach (Transform o in o3.transform)
                    {
                        spawnPoints3.Add(o.gameObject);
                        //spawnPoints3 = spawnPoints3.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints3.Count(); i++)
                    {
                        if (spawnPoints3[i].GetComponent<RoomSpawner>().openingDirection == 8)
                        {
                            o3.GetComponent<Transform>().transform.localPosition += new Vector3(0.5f, 0, 0);
                           
                        }
                    }
                    break;
                case 4:
                    rand = Random.Range(0, templates.rightRooms.Length);
                    GameObject o4 = Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                    //Store child 
                    List<GameObject> spawnPoints4 = new List<GameObject>();
                    foreach (Transform o in o4.transform)
                    {
                        spawnPoints4.Add(o.gameObject);
                        //spawnPoints4 = spawnPoints4.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints4.Count(); i++)
                    {
                        if (spawnPoints4[i].GetComponent<RoomSpawner>().openingDirection == 7)
                        {
                            o4.GetComponent<Transform>().transform.localPosition -= new Vector3(0.5f, 0, 0);
                            spawned = false;
                        }
                    }
                    
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
            Debug.Log("Closed Room created");
            Destroy(gameObject);

        }

          //  if (gameObject.GetComponent<RoomSpawner>().openingDirection == 5)
          //  {
          //      o.GetComponent<Transform>().transform.localPosition += new Vector3(0, 0.5f, 0);
          //  }
          //else if(gameObject.GetComponent<RoomSpawner>().openingDirection == 6)
          //  { 
          //      o.GetComponent<Transform>().transform.localPosition -= new Vector3(0, 0.5f, 0); 
          //  }
          //  else if(gameObject.GetComponent<RoomSpawner>().openingDirection == 7)
          //  { o.GetComponent<Transform>().transform.localPosition -= new Vector3(0.5f, 0, 0); }
          //  else if(gameObject.GetComponent<RoomSpawner>().openingDirection == 8)
          //  { o.GetComponent<Transform>().transform.localPosition += new Vector3(0.5f, 0, 0); }


           // List<GameObject> spawnPoints5 = new List<GameObject>();
        
        //foreach (Transform o in templates.closedRoom.transform)
        //{
        //    spawnPoints5.Add(o.gameObject);
        //    //spawnPoints4 = spawnPoints4.OrderBy(go => go.name).ToList();
        //}
        //for (int i = 0; i < spawnPoints5.Count(); i++)
        //{
               
        //    if (spawnPoints5[i].GetComponent<RoomSpawner>().openingDirection == 5)
        //    {
        //        templates.closedRoom.GetComponentInParent<Transform>().transform.localPosition += new Vector3(0, 0.5f, 0);
        //    }
        //    if (spawnPoints5[i].GetComponent<RoomSpawner>().openingDirection == 6)
        //    {
                
        //    }
        //    if (spawnPoints5[i].GetComponent<RoomSpawner>().openingDirection == 7)
        //    {
                
        //    }
        //    if (spawnPoints5[i].GetComponent<RoomSpawner>().openingDirection == 8)
        //    {
                
        //    }

        //}                  
            
            
        
                           
    }
}
