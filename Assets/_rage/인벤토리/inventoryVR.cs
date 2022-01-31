
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class inventoryVR : UdonSharpBehaviour
{
    private void FixedUpdate()
    {
        this.transform.SetPositionAndRotation(Networking.LocalPlayer.GetPosition(), Networking.LocalPlayer.GetRotation());
    }
}
