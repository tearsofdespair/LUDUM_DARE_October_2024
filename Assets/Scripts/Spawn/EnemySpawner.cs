using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemySpawner : MonoBehaviour
{
    private ObjectPoolService _poolService;
    private List<Wave> _waves;

    [Inject]
    public void Construct(ObjectPoolService poolService, List<Wave> waves)
    {
        this._poolService = poolService;
        this._waves = waves;
        Debug.Log("Zenject worked for EnemySpawner");
    }

    private void Start()
    {
        StartCoroutine(StartSpawn());
    }

    IEnumerator StartSpawn()
    {
        foreach (Wave wave in _waves)
        {
            foreach(SpawnPointSpawnSettings miniWave in wave.MiniWaves)
            {
                foreach(GameObject enemy in miniWave.Enemyies)
                {
                    GameObject enemyInstance = _poolService.Spawn(enemy);
                    enemyInstance.transform.position = miniWave.Spawnoint.position;
                    yield return new WaitForSeconds(miniWave.EnemySpawnColdown);
                }
            }
            yield return new WaitForSeconds(wave.MiniWavesGap);
        }
        
    }

}
