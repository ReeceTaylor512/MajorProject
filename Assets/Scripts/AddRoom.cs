using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
    private RoomTemplates _templates;

    private void Start()
    {
        _templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        _templates.rooms.Add(this.gameObject);
        foreach(Transform child in transform)
        {
            if(child.tag == "Wall")
            {
                _templates.WallSpawnPoints.Add(child.gameObject);
            }
            
        }
        
    }
}
