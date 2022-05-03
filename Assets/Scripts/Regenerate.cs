using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regenerate : MonoBehaviour
{
	[SerializeField] private RoomTemplates templates;
	[SerializeField] private GameObject EntryRoom;
	public static bool buttonOn = false;

    public void Update()
    {
    
		if (buttonOn == true)
		{
			StartCoroutine(RegenCoroutine());
		}		
		
	}

	private IEnumerator RegenCoroutine()
	{
		yield return new WaitForSeconds(4.0f); // Initial Delay
		while (buttonOn == true)
		{
			
			RegenDungeon();
			yield return null; 
		}
		yield return new WaitForSeconds(10.0f);
	}

	public void RegenDungeon()
	{
		
		GameObject[] rooms = GameObject.FindGameObjectsWithTag("SpawnedRooms");
		
		for (int i = 0; i < rooms.Length; i++)
		{
			Destroy(rooms[i]);
		}

		templates.rooms = new List<GameObject>();
		templates.WallSpawnPoints = new List<GameObject>();
		
		

		Instantiate(EntryRoom, transform.localPosition, transform.rotation);
		
		templates.waitTime = templates.startWaitTime;
		templates._spawnedBoss = false;
		templates.keySpawned = false;
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("ClosedRoom"))
        {
			Destroy(other.gameObject);
        }
    }
}
