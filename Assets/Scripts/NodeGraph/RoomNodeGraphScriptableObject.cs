using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeGraph", menuName = "Scriptable Objects/Dungeon/Room Node Graph")]
public class RoomNodeGraphScriptableObject : ScriptableObject
{
    [HideInInspector] public RoomNodeTypeListScriptableObject roomNodeTypeList;
    [HideInInspector] public List<RoomNodeScriptableObject> roomNodeList = new List<RoomNodeScriptableObject>();
    [HideInInspector] public Dictionary<string, RoomNodeScriptableObject> roomNodeDictionary = new Dictionary<string, RoomNodeScriptableObject>();
}
