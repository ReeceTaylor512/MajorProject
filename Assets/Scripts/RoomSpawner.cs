
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class RoomSpawner : MonoBehaviour
{
    [SerializeField] private int openingDirection;

    private int maxNumRooms;

    private RoomTemplates templates;
    //private RoomProperties properties; 

    private int rand;
    private bool spawned = false;

    private float waitTime = 4f;
    


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
                    if(spawnPoints1[0].GetComponent<RoomSpawner>().openingDirection == 6)
                    {
                         o1.GetComponentInParent<Transform>().transform.localPosition += new Vector3(0, 0.5f, 0);
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
                    if (spawnPoints2[1].GetComponent<RoomSpawner>().openingDirection == 6)
                    {
                        o2.GetComponentInParent<Transform>().transform.localPosition -= new Vector3(0, 0.5f, 0);
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
                    if (spawnPoints3[2].GetComponent<RoomSpawner>().openingDirection == 8)
                    {
                        o3.GetComponentInParent<Transform>().transform.localPosition += new Vector3(0.5f, 0, 0);
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
                    if (spawnPoints4[3].GetComponent<RoomSpawner>().openingDirection == 7)
                    {
                        o4.GetComponentInParent<Transform>().transform.localPosition -= new Vector3(0.5f, 0, 0);
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
         
            Destroy(gameObject);
    }
            spawned = true;                
    }
}
