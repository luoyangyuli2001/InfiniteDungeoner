using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrentPlayer", menuName = "Scriptable Objects/Player/Current Player")]
public class CurrentPlayerScriptableObject : ScriptableObject
{
    public PlayerDetailsScriptableObject playerDetails;
    public string playerName;

}
