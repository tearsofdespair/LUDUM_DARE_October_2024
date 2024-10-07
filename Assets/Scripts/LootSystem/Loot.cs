using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Loot", menuName = "LootSystem/Loot")]
public class Loot : ScriptableObject
{
    public GameObject LootPrefab;
    public string LootName;
    public int DropChance;

    public Loot(GameObject lootPrefab, string lootName, int dropChance)
    {
        LootPrefab = lootPrefab;
        LootName = lootName;
        DropChance = dropChance;
    }
}
