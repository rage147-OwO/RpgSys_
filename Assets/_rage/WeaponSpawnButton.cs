
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class WeaponSpawnButton : UdonSharpBehaviour
{
    public objectPool Pool;
    private void Start()
    {
        ((BoxCollider)this.GetComponent(typeof(BoxCollider))).isTrigger = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Networking.IsOwner(Pool.gameObject))
        {
            for (int i = 0; i < Pool.오브젝트풀.Pool.Length; i++)
            {
                if (Pool.오브젝트풀.Pool[i].gameObject == other)
                {
                    Pool.SendCustomEvent("PoolReturn" + i.ToString());
                      
                }
            }
        }
    }
    public override void Interact()
    {                             
        for(int i = 0; i < Pool.오브젝트풀.Pool.Length; i++)
        {
            if (!Pool.오브젝트풀.Pool[i].gameObject.activeInHierarchy)
            {            
                Pool.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "Spawn" + i.ToString());
                break;
            }
        }
    }
}
