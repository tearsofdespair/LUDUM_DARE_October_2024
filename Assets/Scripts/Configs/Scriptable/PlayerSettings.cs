using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Settings/PlayerSettings")]
public class PlayerSettings : ScriptableObject
{
    [field: SerializeField, Range(0, 10000)] public float HealthPoints;
    [field: SerializeField, Range(0, 2000)] public float Attack;
    [field: SerializeField, Range(0, 500)] public float Defence;
}
