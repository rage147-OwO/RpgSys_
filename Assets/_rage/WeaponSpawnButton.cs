
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class WeaponSpawnButton : UdonSharpBehaviour
{
    public objectPool Pool;
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < Pool.오브젝트풀.Pool.Length; i++)
        {
            if (Pool.오브젝트풀.Pool[i].gameObject==other)
            {
                Pool.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "PoolReturn" + i.ToString());
            }
        }
    }
    public override void Interact()
    {                             
        for(int i = 0; i < Pool.오브젝트풀.Pool.Length; i++)
        {
            if (!Pool.오브젝트풀.Pool[i].gameObject.activeInHierarchy)
            {
                Pool.오브젝트풀.TryToSpawn();
                break;
            }
        }
    }
}
