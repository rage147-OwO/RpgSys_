
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class NetworkSysSub : UdonSharpBehaviour
{
    public NetworkSysMain main;
    VRCPlayerApi Owner;
    void OnEnable()
    {
        Owner = Networking.GetOwner(this.gameObject);
        if (Owner.isLocal && !Owner.isMaster)
        {
            for (int i = 0; i < main.pool.Pool.Length; i++)
            {
                if (this.gameObject == main.pool.Pool[i].gameObject)
                {
                    main.PlayerObjectNum = (byte)i;
                }
            }
        }
    }
}
