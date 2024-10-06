using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wave", menuName = "SpawnSystem/Wave")]
public class Wave : ScriptableObject
{
    public List<SpawnPointSpawnSettings> MiniWaves;
    public float MiniWavesGap;
}
