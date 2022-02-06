
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class WeaponSpawnButton : UdonSharpBehaviour
{
    public objectPool Pool;
    public override void Interact()
    {
        Pool.오브젝트풀.TryToSpawn();
    }
}
