using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerMonoInstaller : MonoInstaller
{
    [SerializeField, Range(0.01f, 5f)] float PlayerSpeed;
    [SerializeField] Rigidbody PlayerRigidbody;

    #region Objects
    PlayerConfig PlayerConfig;
    #endregion

    public override void InstallBindings()
    {
        InstallObjects();
        Bind();
    }

    private void InstallObjects()
    {
        PlayerConfig = new PlayerConfig(PlayerSpeed, PlayerRigidbody);
    }

    private void Bind()
    {
        Container.Bind<PlayerConfig>().FromInstance(PlayerConfig).AsSingle().NonLazy();
    }
}
