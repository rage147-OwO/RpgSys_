
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class WeaponSpawnButton : UdonSharpBehaviour
{
    public objectPool Pool;
    Transform temp;
    private void Start()
    {
        temp = transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Networking.IsOwner(other.gameObject))
        {
            if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) != null)
            {
                Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right).Drop();
            }
            if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) != null)
            {
                Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left).Drop();
            }           
        }
        if (Networking.IsMaster)
        {
            if (other.GetComponentInParent<objectPool>() != null)
            {
                other.GetComponentInParent<objectPool>().SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "PoolReturn" + other.transform.GetSiblingIndex().ToString());;
            }
        }
    }

    public override void Interact()
    {                             
        for(int i = 0; i < Pool.오브젝트풀.Pool.Length; i++)
        {
            if (!Pool.오브젝트풀.Pool[i].gameObject.activeInHierarchy)
            {
                SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "TrySpawn");
                break;
            }
        }
    }
    public void TrySpawn()
    {
        Pool.오브젝트풀.TryToSpawn();
    }
}
