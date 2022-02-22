
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class AdminTpButton : UdonSharpBehaviour
{
    public Transform Target;
    public GameObject Wall;
    
    void Start()
    {
        if (Networking.LocalPlayer.displayName != "rage147")
        {
            this.gameObject.SetActive(false);
        }
    }
    public override void Interact()
    {
        Networking.LocalPlayer.TeleportTo(Target.position, Target.rotation);
    }
}
