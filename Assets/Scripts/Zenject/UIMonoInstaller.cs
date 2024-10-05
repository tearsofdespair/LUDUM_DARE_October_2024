using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UIMonoInstaller : MonoInstaller
{
    public GameObject SettingsPanel;

    public override void InstallBindings()
    {
        Container.Bind<GameObject>().FromInstance(SettingsPanel).NonLazy();
    }
}
