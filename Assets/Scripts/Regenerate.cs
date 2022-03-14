using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regenerate : MonoBehaviour
{
	[SerializeField] private RoomTemplates templates;


	public void RegenerateDungeon()
	{
		templates.Rooms = new List<GameObject>();
		
		GameObject[] rooms = GameObject.FindGameObjectsWithTag("SpawnedRooms");

		for (int i = 0; i < rooms.Length; i++)
		{
			Destroy(rooms[i]);
		}
		Instantiate(templates.entryRoom, transform.localPosition, transform.rotation);

	}
}
