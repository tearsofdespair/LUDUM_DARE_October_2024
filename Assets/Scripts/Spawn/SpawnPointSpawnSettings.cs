using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnPointSpawnSettings", menuName = "SpawnSystem/SpawnPointSpawnSettings")]
public class SpawnPointSpawnSettings : ScriptableObject
{
    public Transform Spawnoint;
    public List<GameObject> Enemyies;
    public float EnemySpawnColdown;
}
