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

    [Rename("Maximum Number of Rooms")]
    public int maxNumRooms;

   


    [MenuItem("Room Properties/Edit Mode Functions")]
    public static void ShowWindow()
    {
        GetWindow<RoomProperties>("Room Properties");
        
    }

    GameObject entryTile;
    Editor entryTileEditor;

    [Range(1, 3)]
    public int roomSize; 
    private void OnGUI()
    {
        
        #region Change Room Size
        
        EditorGUI.BeginChangeCheck(); //Checks for GUI changes, in our case we're checking for some variables         
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>(); //Find the Room Templates object (object with the room arrays)
        roomSize = EditorGUILayout.IntSlider(roomSize, 1, 3); //Slider in window
        templates.size = roomSize; //Sets the int variable size (in RoomTemplates) to the value of the above slider
         
        if(EditorGUI.EndChangeCheck()) //Finishes checking for GUI changes
        {
            templates.ChangeSize(); //Commits the changes
            
        }
        
        #endregion


        #region Preview Window
        entryTile = (GameObject)EditorGUILayout.ObjectField(entryTile, typeof(GameObject), true);
        if (entryTile != null)
        {
            if (entryTileEditor == null)
            {
                entryTileEditor = Editor.CreateEditor(entryTile);
            }
                

            entryTileEditor.OnPreviewGUI(GUILayoutUtility.GetRect(roomSize*100, roomSize*100), EditorStyles.whiteLabel);
        }
        #endregion
    }










}
