using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

[ExecuteInEditMode]
public class RoomProperties : EditorWindow
{

    private RoomTemplates templates;
    //[SerializeField] private RoomSpawner spawner;
    public static Vector3 scale;

    
    private void Awake()
    {
        //
    }

    [MenuItem("Room Properties/Edit Mode Functions")]
    public static void ShowWindow()
    {
        GetWindow<RoomProperties>("Room Properties");
        
    }


    private void OnGUI()
    {
        EditorGUI.BeginChangeCheck();
       //templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        //spawner = GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<RoomSpawner>();
        //EditorGUILayout.BeginHorizontal();
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        roomSize = EditorGUILayout.IntSlider(roomSize, 1, 3);
        templates.size = roomSize;
        if(EditorGUI.EndChangeCheck())
        {
            templates.ChangeSize();
        }

        //scale = EditorGUILayout.Vector3Field("Room Size", scale);

        //roomSize = EditorGUILayout.IntField("Room", templates.roomSize);
        //templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        //ChangeSize();
    }

    //void ChangeSize()
    //{
    //    //scale = new Vector3(roomSize, 1, roomSize);
        
    //    //templates.size = scale;
    //}

    //private void Update()
    //{
    //    scale = new Vector3(roomSize,1,roomSize);
    //    templates.size = scale;
    //}

    [Rename("Maximum Number of Rooms")]
    public int maxNumRooms;

    [Range(1, 3)]
    public int roomSize;








}
