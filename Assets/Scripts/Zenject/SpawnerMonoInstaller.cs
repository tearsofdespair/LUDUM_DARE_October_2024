using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnerMonoInstaller : MonoInstaller
{
    [SerializeField] public List<Wave> Waves = new List<Wave>();

    public override void InstallBindings()
    {
        Container.Bind<List<Wave>>().FromInstance(Waves).NonLazy();
        Container.Bind<ObjectPoolService>().AsSingle().WithArguments<PoolSettings>(new PoolSettings()).NonLazy();
    }
}
