using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

public class WawesMonoInstaller : MonoInstaller
{
    [InspectorLabel("Первый показатель - это время, после которого у нас заканчивается волна, Второй - это настройки самой волны, словарь с спавнпоинтом, которому соответствую префабы врагов, которые должны появиться из этого спавнера")]
    [SerializeField]public Dictionary<float, Dictionary<Transform, List<GameObject>>> EnemysForSpawnPoints;
}
