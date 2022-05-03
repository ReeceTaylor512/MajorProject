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
    
    private List<GameObject> spawnPoints = new List<GameObject>();

    

    private void Awake()
    {
        Destroy(gameObject, waitTime);

        
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>(); //Find the Room Templates object (object with the room arrays
        Invoke(nameof(SpawnRooms), 0.1f);


    }
   
    
    void SpawnRooms()
    {
        
        if (spawned == false /*templates.Rooms.Count < properties.maxNumRooms*/)
        {
            switch (openingDirection)
            {
                #region case 1
                case 1:
                    rand = Random.Range(0, templates.bottomRooms.Length);
                    GameObject o1 = Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                    ////Store child 
                    List<GameObject> spawnPoints1 = new List<GameObject>();
                    foreach (Transform o in o1.transform)
                    {
                        if (o.gameObject.tag.Contains("SpawnPoint"))
                        {
                            spawnPoints1.Add(o.gameObject);
                        }
                        //spawnPoints1 = spawnPoints1.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints1.Count; i++)
                    {
                        if (spawnPoints1[i].GetComponent<RoomSpawner>().openingDirection == 5)
                        {
                            o1.GetComponent<Transform>().transform.localPosition += new Vector3(0, templates.ShiftAmount, 0);
                            

                        }
                    }

                    break;
                #endregion
                #region case 2
                case 2:
                    rand = Random.Range(0, templates.topRooms.Length);
                    GameObject o2 = Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);

                    //Store child 
                    List<GameObject> spawnPoints2 = new List<GameObject>();
                    foreach (Transform o in o2.transform)
                    {
                        if (o.gameObject.tag.Contains("SpawnPoint"))
                        {
                            spawnPoints2.Add(o.gameObject);
                            
                        }
                        //spawnPoints2 = spawnPoints2.OrderBy(go => go.name).ToList();
                       
                    }
                    for (int i = 0; i < spawnPoints2.Count; i++)
                    {
                        if (spawnPoints2[i].GetComponent<RoomSpawner>().openingDirection == 6)
                        {
                            o2.GetComponent<Transform>().transform.localPosition -= new Vector3(0, templates.ShiftAmount, 0);

                        }
                    }

                    break;
                #endregion
                #region case 3
                case 3:
                    rand = Random.Range(0, templates.leftRooms.Length);
                    GameObject o3 = Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                    //Store child 
                    List<GameObject> spawnPoints3 = new List<GameObject>();
                    foreach (Transform o in o3.transform)
                    {
                        if (o.gameObject.tag.Contains("SpawnPoint"))
                        {
                            spawnPoints3.Add(o.gameObject);
                        }
                        //spawnPoints3 = spawnPoints3.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints3.Count; i++)
                    {
                        if (spawnPoints3[i].GetComponent<RoomSpawner>().openingDirection == 8)
                        {
                            o3.GetComponent<Transform>().transform.localPosition += new Vector3(templates.ShiftAmount, 0, 0);
                            
                        }
                    }

                    break;
                #endregion
                #region case 4
                case 4:
                    rand = Random.Range(0, templates.rightRooms.Length);
                    GameObject o4 = Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                    
                    //Store child 
                    List<GameObject> spawnPoints4 = new List<GameObject>();
                    foreach (Transform o in o4.transform)
                    {
                        if(o.gameObject.tag.Contains("SpawnPoint"))
                        {
                            spawnPoints4.Add(o.gameObject);
                        }
                        

                        //spawnPoints4 = spawnPoints4.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints4.Count; i++)
                    {
                        if (spawnPoints4[i].GetComponent<RoomSpawner>().openingDirection == 7)
                        {
                            o4.GetComponent<Transform>().transform.localPosition -= new Vector3(templates.ShiftAmount, 0, 0);
                            
                        }
                    }

                    break;
                #endregion
                #region Case 5 
                case 5:                    
                    GameObject o5 = Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                    List<GameObject> spawnPoints5 = new List<GameObject>();
                    foreach (Transform o in o5.transform)
                    {
                        if (o.gameObject.tag.Contains("SpawnPoint"))
                        {
                            spawnPoints5.Add(o.gameObject);
                        }
                        //spawnPoints4 = spawnPoints4.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints5.Count; i++)
                    {
                        if (spawnPoints5[i].GetComponent<RoomSpawner>().openingDirection == 5)
                        {
                            o5.GetComponent<Transform>().transform.localPosition += new Vector3(0, templates.ShiftAmount, 0);

                        }
                    }
                    break;
                    #endregion
                #region Case 6 
                case 6:
                    
                    GameObject o6 = Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
                    List<GameObject> spawnPoints6 = new List<GameObject>();
                    foreach (Transform o in o6.transform)
                    {
                        if (o.gameObject.tag.Contains("SpawnPoint"))
                        {
                            spawnPoints6.Add(o.gameObject);
                        }
                        //spawnPoints6 = spawnPoints6.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints6.Count; i++)
                    {
                        if (spawnPoints6[i].GetComponent<RoomSpawner>().openingDirection == 6)
                        {
                            o6.GetComponent<Transform>().transform.localPosition -= new Vector3(0, templates.ShiftAmount, 0);

                        }
                    }
                    break;
                    #endregion
                #region Case 7 
                case 7:
                    
                    GameObject o7 = Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                    List<GameObject> spawnPoints7 = new List<GameObject>();
                    foreach (Transform o in o7.transform)
                    {
                        if (o.gameObject.tag.Contains("SpawnPoint"))
                        {
                            spawnPoints7.Add(o.gameObject);
                        }
                        //spawnPoints7 = spawnPoints7.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints7.Count; i++)
                    {
                        if (spawnPoints7[i].GetComponent<RoomSpawner>().openingDirection == 8)
                        {
                            o7.GetComponent<Transform>().transform.localPosition += new Vector3(templates.ShiftAmount, 0, 0);

                        }
                    }
                    break;
                    #endregion
                #region Case 8 
                case 8:
                    
                    GameObject o8 = Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                    List<GameObject> spawnPoints8 = new List<GameObject>();
                    foreach (Transform o in o8.transform)
                    {
                        if (o.gameObject.tag.Contains("SpawnPoint"))
                        {
                            spawnPoints8.Add(o.gameObject);
                        }
                        //spawnPoints8 = spawnPoints8.OrderBy(go => go.name).ToList();
                    }
                    for (int i = 0; i < spawnPoints8.Count; i++)
                    {
                        if (spawnPoints8[i].GetComponent<RoomSpawner>().openingDirection == 7)
                        {
                            o8.GetComponent<Transform>().transform.localPosition -= new Vector3(templates.ShiftAmount, 0, 0);

                        }
                    }
                    break;
                    #endregion

            }
            spawned = true; 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        

            if (other.gameObject.tag.Contains("SpawnPoint") && other.GetComponent<RoomSpawner>().spawned == false && spawned == false)
            {

                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
        
    }
}
