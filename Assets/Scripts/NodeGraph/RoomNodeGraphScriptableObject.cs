using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeGraph", menuName = "Scriptable Objects/Dungeon/Room Node Graph")]
public class RoomNodeGraphScriptableObject : ScriptableObject
{
    [HideInInspector] public RoomNodeTypeListScriptableObject roomNodeTypeList;
    [HideInInspector] public List<RoomNodeScriptableObject> roomNodeList = new List<RoomNodeScriptableObject>();
    [HideInInspector] public Dictionary<string, RoomNodeScriptableObject> roomNodeDictionary = new Dictionary<string, RoomNodeScriptableObject>();

    private void Awake()
    {
        LoadRoomNodeDictionary();
    }

    private void LoadRoomNodeDictionary()
    {
        roomNodeDictionary.Clear();

        foreach (RoomNodeScriptableObject node in roomNodeList)
        {
            roomNodeDictionary[node.id] = node;
        }
    }

    #region Editor Code
#if UNITY_EDITOR

    [HideInInspector] public RoomNodeScriptableObject roomNodeToDrawLineFrom = null;
    [HideInInspector] public Vector2 linePosition;

    public void OnValidate()
    {
        LoadRoomNodeDictionary();
    }

    public void SetNodeToDrawConnectionLineFrom(RoomNodeScriptableObject node, Vector2 position)
    {
        roomNodeToDrawLineFrom = node;
        linePosition = position;
    }

#endif
    #endregion
}
