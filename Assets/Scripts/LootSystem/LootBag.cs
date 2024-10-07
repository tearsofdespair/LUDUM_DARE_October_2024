using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBag : MonoBehaviour
{
    public List<Loot> LootList;


    public Loot GetDroppedItem()
    {
        int randomNumber = Random.Range(0, 101);
        List<Loot> possibleItems = new List<Loot>();
        foreach(Loot item in LootList)
        {
            if(randomNumber <= item.DropChance)
            {
                possibleItems.Add(item);
            }
        }

        if(possibleItems.Count > 0)
        {
            Loot droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
            return droppedItem;
        }
        Debug.Log("No loot dropped");
        return null;
    }

    public void InstantiateLoot(Vector3 spawnPosition)
    {
        Loot droppedItem = GetDroppedItem();
        if(droppedItem != null)
        {
            GameObject lootGameObject = Instantiate(droppedItem.LootPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
